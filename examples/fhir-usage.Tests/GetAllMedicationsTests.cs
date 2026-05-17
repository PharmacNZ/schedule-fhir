using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Moq;

public class GetAllMedicationsTests
{
    // Tests for GetAllMedications action, which retrieves Medication resources with optional _lastUpdated filter and prints count of results.
    [Fact]
    // Verifies that when no lastUpdated filter is provided, SearchAsync is called with empty SearchParams.
    public async System.Threading.Tasks.Task Execute_NoFilter_CallsSearchWithEmptyParams()
    {
        var bundle = FhirTestHelpers.BuildBundle(
            FhirTestHelpers.BuildMedication("med-1", "Paracetamol"),
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
    // Verifies that when a lastUpdated filter is provided, SearchAsync is called with SearchParams containing _lastUpdated parameter.
    public async System.Threading.Tasks.Task Execute_WithLastUpdated_AddsLastUpdatedParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetAllMedications(mock.Object);
        await action.Execute(new GetAllMedications.Parameters("2026-05-01"));

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("_lastUpdated", paramNames);
    }

    [Fact]
    // Verifies that when the search returns an empty bundle, a not found message is printed.

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
    // Verifies that when the search returns a bundle with entries, the count of results is printed.
    public async System.Threading.Tasks.Task Execute_WithResults_PrintsCount()
    {
        var bundle = FhirTestHelpers.BuildBundle(FhirTestHelpers.BuildMedication("med-1"));
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<Medication>(It.IsAny<SearchParams?>())).ReturnsAsync(bundle);

        var action = new GetAllMedications(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetAllMedications.Parameters(string.Empty)).Wait());

        Assert.Contains("1", output);
        Assert.Contains("Medication", output);
    }
}
