using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;
using System.Text.Json;
using System.Text;

public class GetSAAuthSchema(FhirClient _client) : IAction<GetSAAuthSchema.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetSAAuthSchema action for resource with sa: {parameters.Id}");


				var query = new SearchParams().Add("cid-code.code", parameters.Id);
				Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);

				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var sa = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Special Authority Id: {parameters.Id}");
					Console.WriteLine($"Received special authority with Id: {sa?.Id}"); //Assumes id is at index 0
					Console.WriteLine($"search param: {sa?.Code?.Coding?[0]?.Code}");
					
					var jsonBase64 = sa.GetExtension("https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/authorization-schema")?.Value?.ToString();
					//HelperFunctions.DecodeBase64JsonExtensionKeepUnicode(jsonBase64 ?? string.Empty);
					HelperFunctions.DecodeBase64JsonExtensionReplaceUnicode(jsonBase64 ?? string.Empty);
				}


				HelperFunctions.PrintResultsCountFromBundle("Special Authority", searchResult);
		}



	public record Parameters(string Id);
}