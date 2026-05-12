using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Text.Json;
using Task = System.Threading.Tasks.Task;

public class GetAllMedications(FhirClient _client) : IAction<GetAllMedications.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting all medications
				Console.WriteLine("Executing GetAllMedications action...");

				var query = new SearchParams();
				if (!string.IsNullOrEmpty(parameters.lastUpdated))
				{
					Console.WriteLine($"Filtering medications by last updated date: {parameters.lastUpdated}");
					query = query.Add("_lastUpdated", $"ge{parameters.lastUpdated}");

				}
			Bundle? searchResult = await _client.SearchAsync<Medication>(query);
			foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var med = result.Resource as Medication;
      		Console.WriteLine($"Received medication with {med?.Code?.Text}");
					//var options = new JsonSerializerOptions { WriteIndented = true };
					//string jsonString = JsonSerializer.Serialize(med, options);

					//Console.WriteLine(jsonString);
					
				}

			HelperFunctions.PrintResultsCountFromBundle("Medication", searchResult);
		}


	public record Parameters(string lastUpdated);
}