using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;
using System.Text.Json;

public class GetPricingByInstance(FhirClient _client) : IAction<GetPricingByInstance.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetPricingByInstance action for pricing with instance: {parameters.instance}");

				string fullInstance = $"Medication/Medication-{parameters.instance}";
				var query = new SearchParams().Add("instance.reference", fullInstance)
					.Add("_profile", "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-pricing");

				Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);

				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))

				{
					var cid = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Charge Item Definition Instance: {parameters.instance}");
					Console.WriteLine($"Received Pricing with Id: {cid?.Id}"); 
					
					/*var options = new JsonSerializerOptions { WriteIndented = true };
			string jsonString = JsonSerializer.Serialize(cid?.Code?.Coding, options);
			Console.WriteLine(jsonString);*/
			
				}

				HelperFunctions.PrintResultsCountFromBundle("Pricing Rule", searchResult);
		}



	public record Parameters(string instance);
}