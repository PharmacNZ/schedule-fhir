using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Moq;

public class GetMedicationByNameTests
{
    [Fact]
    public async System.Threading.Tasks.Task Execute_ByName_AddsNameSearchParam()
    {
        var bundle = FhirTestHelpers.BuildBundle(FhirTestHelpers.BuildMedication("med-1", "Leuprorelin")); //TODO: change input?
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetMedicationByName(mock.Object);
        await action.Execute(new GetMedicationByName.Parameters("Leuprorelin"));

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("name", paramNames);
    }

    [Fact]
    public async System.Threading.Tasks.Task Execute_EmptyResults_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<Medication>(It.IsAny<SearchParams?>()))
            .ReturnsAsync(new Bundle { Entry = [] });

        var action = new GetMedicationByName(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetMedicationByName.Parameters("Unknown")).Wait());

        Assert.Contains("No Medication found.", output);
    }
}

public class GetMedicationByBrandTests
{
    [Fact]
    public async System.Threading.Tasks.Task Execute_ByBrand_AddsBrandSearchParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetMedicationByBrand(mock.Object);
        await action.Execute(new GetMedicationByBrand.Parameters("Ricovir")); //TODO: change input?

        Assert.Single(captured);
        Assert.Contains("brand", captured[0]?.Parameters.Select(p => p.Item1) ?? []);
    }
}

public class GetMedicationByCategoryTests
{
    [Fact]
    public async System.Threading.Tasks.Task Execute_ByCategory_AddsCategorySearchParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetMedicationByCategory(mock.Object);
        await action.Execute(new GetMedicationByCategory.Parameters("Special Foods")); //TODO: change input?

        Assert.Single(captured);
        Assert.Contains("category", captured[0]?.Parameters.Select(p => p.Item1) ?? []);
    }
}
