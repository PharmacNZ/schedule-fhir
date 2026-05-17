using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Moq;

public class GetAllFundingRulesTests
{
    // Tests for GetAllFundingRules action, which retrieves all funding rules with optional last updated filter.
        private const string FundingProfile =
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules";


    [Fact]
    // Verifies that executing without a last updated filter adds the correct profile parameter to the search.
    public async System.Threading.Tasks.Task Execute_NoFilter_AddsProfileParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetAllFundingRules(mock.Object);
        await action.Execute(new GetAllFundingRules.Parameters(string.Empty));

        Assert.Single(captured);
        var profileValues = captured[0]?.Parameters
            .Where(p => p.Item1 == "_profile")
            .Select(p => p.Item2)
            .ToList() ?? [];
        Assert.Contains(FundingProfile, profileValues);
    }

    [Fact]
    // Verifies that executing with a last updated filter adds the _lastUpdated parameter to the search.
    public async System.Threading.Tasks.Task Execute_WithLastUpdated_AddsLastUpdatedParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetAllFundingRules(mock.Object);
        await action.Execute(new GetAllFundingRules.Parameters("2026-05-01"));

        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("_lastUpdated", paramNames);
    }

    [Fact]
    // Verifies that executing with results prints the count of funding rules found.
    public async System.Threading.Tasks.Task Execute_WithResults_PrintsCount()
    {
        var bundle = FhirTestHelpers.BuildBundle(FhirTestHelpers.BuildChargeItemDefinition("FR-001"));
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.SearchAsync<ChargeItemDefinition>(It.IsAny<SearchParams?>())).ReturnsAsync(bundle);

        var action = new GetAllFundingRules(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetAllFundingRules.Parameters(string.Empty)).Wait());

        Assert.Contains("1", output);
        Assert.Contains("Funding Rule", output);
    }

   
}

public class GetFundingByIdTests
{
    // Tests for GetFundingRulesById action, which retrieves a funding rule by its ID.
    [Fact]
    // Verifies that executing with a valid ID calls GetAsync with the correctly constructed resource ID.
    public async System.Threading.Tasks.Task Execute_ById_CallsGetWithConstructedId()
    {
        var cid = FhirTestHelpers.BuildChargeItemDefinition("ChargeItemDefinition-FR-123", description: "Funding Rule Description");
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync("ChargeItemDefinition/ChargeItemDefinition-FR-123")).ReturnsAsync(cid);

        var action = new GetFundingRulesById(mock.Object);
        await action.Execute(new GetFundingRulesById.Parameters("FR-123"));

        mock.Verify(c => c.GetAsync("ChargeItemDefinition/ChargeItemDefinition-FR-123"), Times.Once);
    }

    [Fact]
    // Verifies that executing with an invalid ID prints a not found message.
    public async System.Threading.Tasks.Task Execute_NotFound_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync(It.IsAny<string>())).ReturnsAsync((Resource?)null);

        var action = new GetFundingRulesById(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetFundingRulesById.Parameters("INVALID")).Wait());

        Assert.Contains("No Funding Rule found.", output);
    }
}

public class GetFundingByInstanceTests
{
    // Tests for GetFundingByInstance action, which retrieves funding rules associated with a specific medication instance.
    private const string FundingProfile =
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules";

    [Fact]
    // Verifies that executing with a medication instance adds the correct instance reference and profile parameters to the search.
    public async System.Threading.Tasks.Task Execute_ByInstance_AddsInstanceReferenceAndProfileParams()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetFundingByInstance(mock.Object);
        await action.Execute(new GetFundingByInstance.Parameters("Ricovir-Tenofovir"));

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("instance.reference", paramNames);
        Assert.Contains("_profile", paramNames);

        var instanceVal = captured[0]?.Parameters.First(p => p.Item1 == "instance.reference").Item2;
        Assert.Equal("Medication/Medication-Ricovir-Tenofovir", instanceVal);

        var profileVal = captured[0]?.Parameters.First(p => p.Item1 == "_profile").Item2;
        Assert.Equal(FundingProfile, profileVal);
    }
}

public class GetAllPricingRulesTests
{
    // Tests for GetAllPricingRules action, which retrieves all pricing rules with optional last updated filter.
    private const string PricingProfile =
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-pricing";

    [Fact]
    // Verifies that executing without a last updated filter adds the correct profile parameter to the search.
    public async System.Threading.Tasks.Task Execute_NoFilter_AddsProfileParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetAllPricingRules(mock.Object);
        await action.Execute(new GetAllPricingRules.Parameters(string.Empty));

        Assert.Single(captured);
        var profileValues = captured[0]?.Parameters
            .Where(p => p.Item1 == "_profile")
            .Select(p => p.Item2)
            .ToList() ?? [];
        Assert.Contains(PricingProfile, profileValues);
    }

    [Fact]
    // Verifies that executing with a last updated filter adds the _lastUpdated parameter to the search.
    public async System.Threading.Tasks.Task Execute_WithLastUpdated_AddsLastUpdatedParam()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetAllPricingRules(mock.Object);
        await action.Execute(new GetAllPricingRules.Parameters("2026-05-01"));

        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("_lastUpdated", paramNames);
    }
}

public class GetPricingByIdTests
{
    // Tests for GetPricingRulesById action, which retrieves a pricing rule by its ID.
    [Fact]
    // Verifies that executing with a valid ID calls GetAsync with the correctly constructed resource ID.
    public async System.Threading.Tasks.Task Execute_ById_CallsGetWithConstructedId()
    {
        var cid = FhirTestHelpers.BuildChargeItemDefinition("ChargeItemDefinition-PR-456", description: "Pricing Rule Description");
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync("ChargeItemDefinition/ChargeItemDefinition-PR-456")).ReturnsAsync(cid);

        var action = new GetPricingRulesById(mock.Object);
        await action.Execute(new GetPricingRulesById.Parameters("PR-456"));

        mock.Verify(c => c.GetAsync("ChargeItemDefinition/ChargeItemDefinition-PR-456"), Times.Once);
    }

    [Fact]
    // Verifies that executing with an invalid ID prints a not found message.
    public async System.Threading.Tasks.Task Execute_NotFound_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync(It.IsAny<string>())).ReturnsAsync((Resource?)null);

        var action = new GetPricingRulesById(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetPricingRulesById.Parameters("INVALID")).Wait());

        Assert.Contains("No Pricing Rule found.", output);
    }
}

public class GetPricingByInstanceTests
{
    // Tests for GetPricingByInstance action, which retrieves pricing rules associated with a specific medication instance.
    private const string PricingProfile =
        "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-pricing";

    [Fact]
    // Verifies that executing with a medication instance adds the correct instance reference and profile parameters to the search.
    public async System.Threading.Tasks.Task Execute_ByInstance_AddsInstanceReferenceAndPricingProfileParams()
    {
        var bundle = FhirTestHelpers.BuildBundle();
        var (mock, captured) = FhirTestHelpers.CreateMockClientCapturingSearchParams<ChargeItemDefinition>(bundle);

        var action = new GetPricingByInstance(mock.Object);
        await action.Execute(new GetPricingByInstance.Parameters("Ricovir-Tenofovir"));

        Assert.Single(captured);
        var paramNames = captured[0]?.Parameters.Select(p => p.Item1).ToList() ?? [];
        Assert.Contains("instance.reference", paramNames);
        Assert.Contains("_profile", paramNames);

        var profileVal = captured[0]?.Parameters.First(p => p.Item1 == "_profile").Item2;
        Assert.Equal(PricingProfile, profileVal);
    }
}
