using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Moq;

public class GetAllSpecialAuthoritiesTests
{
    // Tests for GetAllSpecialAuthorities action, which retrieves all special authorities with optional last updated filter.
    private const string SaProfile =
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority";

    [Fact]
    // Verifies that executing without a last updated filter adds the correct profile parameter to the search.
    public async System.Threading.Tasks.Task Execute_NoFilter_AddsProfileParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetAllSpecialAuthorities(mock.Object);
        await action.Execute(new GetAllSpecialAuthorities.Parameters(string.Empty));

        Assert.Single(captured);
        var paramValues = captured[0]?.Parameters
            .Where(p => p.Item1 == "_profile")
            .Select(p => p.Item2)
            .ToList() ?? [];
        Assert.Contains(SaProfile, paramValues);
    }

    [Fact]
    // Verifies that executing with a last updated filter adds the _lastUpdated parameter to the search.
    public async System.Threading.Tasks.Task Execute_WithLastUpdated_AddsLastUpdatedParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetAllSpecialAuthorities(mock.Object);
        await action.Execute(new GetAllSpecialAuthorities.Parameters("2024-06-01"));

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("_lastUpdated", paramNames);
    }

    [Fact]
    // Verifies that executing with results prints the correct count of special authorities.
    public async System.Threading.Tasks.Task Execute_WithResults_PrintsCount()
    {
        var bundle = FhirTestHelpers.BuildBundle(
            FhirTestHelpers.BuildChargeItemDefinition("SA2525"),
            FhirTestHelpers.BuildChargeItemDefinition("SA2526"));
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<ChargeItemDefinition>(It.IsAny<SearchParams?>())).ReturnsAsync(bundle);

        var action = new GetAllSpecialAuthorities(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetAllSpecialAuthorities.Parameters(string.Empty)).Wait());

        Assert.Contains("2", output);
        Assert.Contains("Special Authority", output);
    }

    [Fact]
    // Verifies that executing with an empty bundle prints a not found message.
    public async System.Threading.Tasks.Task Execute_EmptyBundle_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<ChargeItemDefinition>(It.IsAny<SearchParams?>()))
            .ReturnsAsync(new Bundle { Entry = [] });

        var action = new GetAllSpecialAuthorities(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetAllSpecialAuthorities.Parameters(string.Empty)).Wait());

        Assert.Contains("No Special Authority found.", output);
    }
}

public class GetSAByIdTests
{
    // Tests for GetSAById action, which retrieves a special authority by its ID.
    [Fact]
    // Verifies that executing with a valid ID calls GetAsync with the correctly constructed resource ID.
    public async System.Threading.Tasks.Task Execute_ById_AddsCidCodeSearchParam()
    {
        var bundle = FhirTestHelpers.BuildBundle(FhirTestHelpers.BuildChargeItemDefinition("SA2525"));
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetSAById(mock.Object);
        await action.Execute(new GetSAById.Parameters("SA2525"));

        Assert.Single(captured);
        Assert.Contains("cid-code.code", captured[0]?.Parameters.Select(p => p.Item1) ?? []);
    }

    [Fact]
    // Verifies that executing with an invalid ID prints a not found message.
    public async System.Threading.Tasks.Task Execute_EmptyResult_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<ChargeItemDefinition>(It.IsAny<SearchParams?>()))
            .ReturnsAsync(new Bundle { Entry = [] });

        var action = new GetSAById(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetSAById.Parameters("INVALID")).Wait());

        Assert.Contains("No Special Authority found.", output);
    }
}

public class GetSAByInstanceTests
{
    // Tests for GetSAByInstance action, which retrieves a special authority by an instance reference.
    private const string SaProfile =
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority";

    [Fact]
    // Verifies that executing with a valid instance adds the correct search parameters for instance reference and profile.
    public async System.Threading.Tasks.Task Execute_ByInstance_AddsInstanceReferenceAndProfileParams()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetSAByInstance(mock.Object);
        await action.Execute(new GetSAByInstance.Parameters("Ricovir-Tenofovir"));

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("instance.reference", paramNames);
        Assert.Contains("_profile", paramNames);

        var instanceVal = captured[0]?.Parameters.First(p => p.Item1 == "instance.reference").Item2;
        Assert.Equal("Medication/Medication-Ricovir-Tenofovir", instanceVal);
    }
}
