using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Moq;

public class GetMedicationByNameTests
{
    // Tests for GetMedicationByName action, which retrieves a medication by its name.
    [Fact]
    /// Verifies that executing GetMedicationByName results in a search with the "name" parameter.
    public async System.Threading.Tasks.Task Execute_ByName_AddsNameSearchParam()
    {
        var bundle = FhirTestHelpers.BuildBundle(FhirTestHelpers.BuildMedication("med-1", "Leuprorelin"));
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetMedicationByName(mock.Object);
        await action.Execute(new GetMedicationByName.Parameters("Leuprorelin"));

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("name", paramNames);
    }

    [Fact]
    /// Verifies that executing GetMedicationByName with no results prints "No Medication found."
    public async System.Threading.Tasks.Task Execute_EmptyResults_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<Medication>(It.IsAny<SearchParams?>()))
            .ReturnsAsync(new Bundle { Entry = [] });

        var action = new GetMedicationByName(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetMedicationByName.Parameters("INVALID")).Wait());

        Assert.Contains("No Medication found.", output);
    }
}

public class GetMedicationByBrandTests
{
    // Tests for GetMedicationByBrand action, which retrieves medications by their brand name.
    [Fact]
    // Verifies that executing GetMedicationByBrand results in a search with the "brand" parameter.
    public async System.Threading.Tasks.Task Execute_ByBrand_AddsBrandSearchParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetMedicationByBrand(mock.Object);
        await action.Execute(new GetMedicationByBrand.Parameters("Ricovir"));

        Assert.Single(captured);
        Assert.Contains("brand", captured[0]?.Parameters.Select(p => p.Item1) ?? []);
    }
}

public class GetMedicationByCategoryTests
{
    // Tests for GetMedicationByCategory action, which retrieves medications by their category.
    [Fact]
    // Verifies that executing GetMedicationByCategory results in a search with the "category" parameter.
    public async System.Threading.Tasks.Task Execute_ByCategory_AddsCategorySearchParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<Medication>(bundle);

        var action = new GetMedicationByCategory(mock.Object);
        await action.Execute(new GetMedicationByCategory.Parameters("Special Foods"));

        Assert.Single(captured);
        Assert.Contains("category", captured[0]?.Parameters.Select(p => p.Item1) ?? []);
    }
}
