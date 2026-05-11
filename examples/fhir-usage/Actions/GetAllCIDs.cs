using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Text.Json;
using Task = System.Threading.Tasks.Task;

public class GetAllChargeItemDefinitions(FhirClient _client) : IAction<GetAllChargeItemDefinitions.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting all charge item definitions
				Console.WriteLine("Executing GetAllChargeItemDefinitions action...");

				
			Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>();
			foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var cid = result.Resource as ChargeItemDefinition;
      		//Console.WriteLine($"Received charge item definition with {cid?.Code?.Text}");
					var options = new JsonSerializerOptions { WriteIndented = true };
					string jsonString = JsonSerializer.Serialize(cid, options);

					Console.WriteLine(jsonString);
					break;
				}

			HelperFunctions.PrintResultsCountFromBundle("ChargeItemDefinition", searchResult);
		}


	public record Parameters();
}