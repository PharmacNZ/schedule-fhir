using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Text.Json;
using Task = System.Threading.Tasks.Task;

public class GetAllSpecialAuthorities(FhirClient _client) : IAction<GetAllSpecialAuthorities.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting all special authorities
				Console.WriteLine("Executing GetAllSpecialAuthorities action...");

			var query = new SearchParams().Add("_profile", "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority");
				
			 Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var sa = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Received special authority with Id: {sa?.Id}");
					Console.WriteLine($"Received special authority with code: {sa?.Code?.Text}");
				}

				HelperFunctions.PrintResultsCountFromBundle("Special Authority", searchResult);
		}


	public record Parameters();
}