using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Moq;

public class GetAllMedicationsTests
{
    [Fact]
    public async System.Threading.Tasks.Task Execute_NoFilter_CallsSearchWithEmptyParams()
    {
        var bundle = FhirTestHelpers.BuildBundle(
            FhirTestHelpers.BuildMedication("med-1", "Paracetamol"), //TODO: change input?
            FhirTestHelpers.BuildMedication("med-2", "Ibuprofen"));
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetAllMedications(mock.Object);
        await action.Execute(new GetAllMedications.Parameters(string.Empty));

        mock.Verify(c => c.SearchAsync<Medication>(It.IsAny<SearchParams?>()), Times.Once);
        Assert.Single(captured);
        // No lastUpdated filter added
        Assert.Empty(captured[0]?.Parameters ?? []);
    }

    [Fact]
    public async System.Threading.Tasks.Task Execute_WithLastUpdated_AddsLastUpdatedParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetAllMedications(mock.Object);
        await action.Execute(new GetAllMedications.Parameters("2024-01-01"));

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("_lastUpdated", paramNames);
    }

    [Fact]
    public async System.Threading.Tasks.Task Execute_EmptyBundle_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<Medication>(It.IsAny<SearchParams?>()))
            .ReturnsAsync(new Bundle { Entry = [] });

        var action = new GetAllMedications(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetAllMedications.Parameters(string.Empty)).Wait());

        Assert.Contains("No Medication found.", output);
    }

    [Fact]
    public async System.Threading.Tasks.Task Execute_WithResults_PrintsCount()
    {
        var bundle = FhirTestHelpers.BuildBundle(FhirTestHelpers.BuildMedication("med-1")); //TODO: change input?
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<Medication>(It.IsAny<SearchParams?>())).ReturnsAsync(bundle);

        var action = new GetAllMedications(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetAllMedications.Parameters(string.Empty)).Wait());

        Assert.Contains("1 Medication results.", output);
    }
}
