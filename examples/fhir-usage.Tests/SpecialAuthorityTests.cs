using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Moq;

public class GetAllSpecialAuthoritiesTests
{
    private const string SaProfile =
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority";

    [Fact]
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
    public async System.Threading.Tasks.Task Execute_WithResults_PrintsCount()
    {
        var bundle = FhirTestHelpers.BuildBundle(
            FhirTestHelpers.BuildChargeItemDefinition("SA2525"), //TODO: change input?
            FhirTestHelpers.BuildChargeItemDefinition("SA2526"));
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<ChargeItemDefinition>(It.IsAny<SearchParams?>())).ReturnsAsync(bundle);

        var action = new GetAllSpecialAuthorities(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetAllSpecialAuthorities.Parameters(string.Empty)).Wait());

        Assert.Contains("2 Special Authority results.", output);
    }

    [Fact]
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
    [Fact]
    public async System.Threading.Tasks.Task Execute_ById_AddsCidCodeSearchParam()
    {
        var bundle = FhirTestHelpers.BuildBundle(FhirTestHelpers.BuildChargeItemDefinition("SA2525")); //TODO: change input?
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetSAById(mock.Object);
        await action.Execute(new GetSAById.Parameters("SA2525"));

        Assert.Single(captured);
        Assert.Contains("cid-code.code", captured[0]?.Parameters.Select(p => p.Item1) ?? []);
    }

    [Fact]
    public async System.Threading.Tasks.Task Execute_EmptyResult_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<ChargeItemDefinition>(It.IsAny<SearchParams?>()))
            .ReturnsAsync(new Bundle { Entry = [] });

        var action = new GetSAById(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetSAById.Parameters("SA9999")).Wait()); //TODO: change input?

        Assert.Contains("No Special Authority found.", output);
    }
}

public class GetSAByInstanceTests
{
    private const string SaProfile =
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority";

    [Fact]
    public async System.Threading.Tasks.Task Execute_ByInstance_AddsInstanceReferenceAndProfileParams()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetSAByInstance(mock.Object);
        await action.Execute(new GetSAByInstance.Parameters("Ricovir-Tenofovir")); //TODO: change input?

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("instance.reference", paramNames);
        Assert.Contains("_profile", paramNames);

        var instanceVal = captured[0]?.Parameters.First(p => p.Item1 == "instance.reference").Item2;
        Assert.Equal("Medication/Medication-Ricovir-Tenofovir", instanceVal);
    }
}
