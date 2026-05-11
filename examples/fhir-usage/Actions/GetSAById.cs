using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;
using System.Text.Json;

public class GetSAById(FhirClient _client) : IAction<GetSAById.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetSAById action for resource with sa: {parameters.Id}");

				// restrict search to special authorities only using _profile search parameter
				//var query = new SearchParams().Add("_profile", "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority");
				//query.Add("_filter", $"code.text+eq+'{parameters.Id}'"); // search by ChargeItemDefinition.code which is where SA number is stored
				//var query = new SearchParams().Where($"Id:exact={parameters.Id}");
				var query = new SearchParams().Add("cid-code.code", parameters.Id);
        //var bundle = await client.SearchAsync<Medication>(searchParams);
				Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);
				//var getResult = await _client.GetAsync($"ChargeItemDefinition$_filter=code.text+eq+'{parameters.Id}'") as ChargeItemDefinition;
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				//if (getResult != null)
				{
					var sa = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Special Authority Id: {parameters.Id}");
					Console.WriteLine($"Received special authority with Id: {sa?.Id}"); //Assumes id is at index 0
					Console.WriteLine($"search param: {sa?.Code?.Coding?[0]?.Code}");

					/*var options = new JsonSerializerOptions { WriteIndented = true };
			string jsonString = JsonSerializer.Serialize(sa?.Code?.Coding, options);
			Console.WriteLine(jsonString);*/
			
				}

				HelperFunctions.PrintResultsCountFromBundle("Special Authority", searchResult);
		}



	public record Parameters(string Id);
}