using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

/// <summary>
/// Wraps FhirClient to implement IFhirClient.
/// </summary>
public class FhirClientAdapter(FhirClient _client) : IFhirClient
{
    public Task<Bundle?> SearchAsync<TResource>(SearchParams? q = null) where TResource : Resource, new()
        => _client.SearchAsync<TResource>(q ?? new SearchParams());

    public Task<Resource?> GetAsync(string url)
        => _client.GetAsync(url);

    public Task<CapabilityStatement?> CapabilityStatementAsync()
        => _client.CapabilityStatementAsync();
}
