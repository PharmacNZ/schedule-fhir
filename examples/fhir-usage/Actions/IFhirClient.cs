using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

/// <summary>
/// Abstraction over FhirClient to enable unit testing.
/// </summary>
public interface IFhirClient
{
    Task<Bundle?> SearchAsync<TResource>(SearchParams? q = null) where TResource : Resource, new();
    Task<Resource?> GetAsync(string url);
    Task<CapabilityStatement?> CapabilityStatementAsync();
}
