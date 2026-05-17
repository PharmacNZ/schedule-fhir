using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;

public class GetMedicationByBrand(IFhirClient _client) : IAction<GetMedicationByBrand.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by brand
				Console.WriteLine($"Executing GetByBrand action for resource with brand: {parameters.Brand}");

				var query = new SearchParams().Add("brand", parameters.Brand);

				Bundle? searchResult = await _client.SearchAsync<Medication>(query);
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var med = result.Resource as Medication;
					Console.WriteLine($"Medication Input Brand: {parameters.Brand}");
					Console.WriteLine($"Received medication with Brand: {med?.GetExtension("https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-brand-name")?.Value?.ToString()}");
				}

				HelperFunctions.PrintResultsCountFromBundle("Medication", searchResult);
		}



	public record Parameters(string Brand);
}