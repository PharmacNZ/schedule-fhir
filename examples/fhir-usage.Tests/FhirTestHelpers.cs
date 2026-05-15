using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;
using Moq;
using System.Globalization;

/// <summary>
/// Shared helpers for building test FHIR bundles and mocking IFhirClient.
/// </summary>
public static class FhirTestHelpers
{
    public static Bundle BuildBundle(params Resource[] resources)
    {
        var bundle = new Bundle();
        foreach (var r in resources)
            bundle.Entry.Add(new Bundle.EntryComponent { Resource = r });
        return bundle;
    }

    public static Medication BuildMedication(string id, string? codeText = null)
        => new() { Id = id, Code = new CodeableConcept { Text = codeText ?? id } };

    public static ChargeItemDefinition BuildChargeItemDefinition(string id, string? codeText = null, string? description = null)
        => new() { Id = id, Code = new CodeableConcept { Text = codeText ?? id }, Description = description ?? id};

    /// <summary>
    /// Captures Console.Out during action and captures SearchParams passed to SearchAsync.
    /// </summary>
    public static (Mock<IFhirClient> mock, List<SearchParams?> capturedParams) CreateMockClientCapturingSearchParams<TResource>(Bundle returnBundle) where TResource : Resource, new()
    {
        var mock = new Mock<IFhirClient>();
        var captured = new List<SearchParams?>();
        mock.Setup(c => c.SearchAsync<TResource>(It.IsAny<SearchParams?>()))
            .Callback<SearchParams?>(captured.Add)
            .ReturnsAsync(returnBundle);
        return (mock, captured);
    }

    public static string CaptureConsoleOutput(Action action)
    {
        var sw = new StringWriter();
        var original = Console.Out;
        Console.SetOut(sw);
        try { action(); }
        finally { Console.SetOut(original); }
        return sw.ToString();
    }
}
