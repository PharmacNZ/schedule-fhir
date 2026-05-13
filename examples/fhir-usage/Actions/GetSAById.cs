using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;
using System.Text.Json;

public class GetSAById(IFhirClient _client) : IAction<GetSAById.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetSAById action for resource with sa: {parameters.Id}");

				var query = new SearchParams().Add("cid-code.code", parameters.Id);
				Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
	
				{
					var sa = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Special Authority Id: {parameters.Id}");
					Console.WriteLine($"Received special authority with Id: {sa?.Id}");
					Console.WriteLine($"search param: {sa?.Code?.Text}");

					/*var options = new JsonSerializerOptions { WriteIndented = true };
			string jsonString = JsonSerializer.Serialize(sa?.Code?.Coding, options);
			Console.WriteLine(jsonString);*/
			
				}

				HelperFunctions.PrintResultsCountFromBundle("Special Authority", searchResult);
		}



	public record Parameters(string Id);
}