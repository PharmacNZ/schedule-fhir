using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Text.Json;
using Task = System.Threading.Tasks.Task;

public class GetAllSAs(FhirClient _client) : IAction<GetAllSAs.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting all special authorities
				Console.WriteLine("Executing GetAllSAs action...");

			var query = new SearchParams().Add("_profile", "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority");
				
			 Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);
			// foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
			// 	{
			// 		var sa = result.Resource as ChargeItemDefinition;
      // 		//Console.WriteLine($"Received medication with {med?.Code?.Text}");
			// 		//var options = new JsonSerializerOptions { WriteIndented = true };
			// 		//string jsonString = JsonSerializer.Serialize(med, options);

			// 		//Console.WriteLine(jsonString);
			// 		Console.WriteLine($"Received special authority with {sa?.Id}");
					
			// 	}

			// HelperFunctions.PrintResultsCountFromBundle("Special Authority", searchResult);
			//Bundle? getResult = await _client.GetAsync($"_profile=https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority") as Bundle;
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var sa = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Received special authority with Id: {sa?.Id}");
					Console.WriteLine($"Received special authority with code: {sa?.Code?.Text}");
				}
				//Console.WriteLine($"Received special authority with ID: {getResult?.Id}");
				//Console.WriteLine($"Received special authority with code: {getResult?.Code?.Text}");

				HelperFunctions.PrintResultsCountFromBundle("Special Authority", searchResult);
		}


	public record Parameters();
}