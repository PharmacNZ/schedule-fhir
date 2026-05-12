using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Text.Json;
using Task = System.Threading.Tasks.Task;

public class GetAllFundingRules(FhirClient _client) : IAction<GetAllFundingRules.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting all funding rules
				Console.WriteLine("Executing GetAllFundingRules action...");

			var query = new SearchParams().Add("_profile", "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-funding-rules");
				if (!string.IsNullOrEmpty(parameters.lastUpdated))
				{
					Console.WriteLine($"Filtering medications by last updated date: {parameters.lastUpdated}");
					query = query.Add("_lastUpdated", $"ge{parameters.lastUpdated}");

				}
			 Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var fr = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Received funding rule with Id: {fr?.Id}");
					Console.WriteLine($"Received funding rule with description: {fr?.Description}");
				}

				HelperFunctions.PrintResultsCountFromBundle("Funding Rule", searchResult);
		}


	public record Parameters(string lastUpdated);
}