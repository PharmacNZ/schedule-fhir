using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Text.Json;
using Task = System.Threading.Tasks.Task;

public class GetAllPricingRules(FhirClient _client) : IAction<GetAllPricingRules.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting all pricing rules
				Console.WriteLine("Executing GetAllPricingRules action...");

			var query = new SearchParams().Add("_profile", "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-pricing");
				
			 Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var fr = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Received pricing rule with Id: {fr?.Id}");
					Console.WriteLine($"Received pricing rule with description: {fr?.Description}");
				}

				HelperFunctions.PrintResultsCountFromBundle("Pricing Rule", searchResult);
		}


	public record Parameters();
}