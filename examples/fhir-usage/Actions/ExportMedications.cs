using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Text.Json;
using Task = System.Threading.Tasks.Task;

public class ExportMedications(FhirClient _client) : IAction<ExportMedications.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting all medications
				Console.WriteLine("Executing ExportMedications action...");

				
			var getResult = await _client.GetAsync($"Patient/$export") as Patient;
				if (getResult != null)
				{
					//var options = new JsonSerializerOptions { WriteIndented = true };
				//string jsonString = JsonSerializer.Serialize(getResult, options);

				//Console.WriteLine(jsonString);
				Console.WriteLine("Exported medications successfully.");
				}
				

				HelperFunctions.PrintResultsCountFromUrl("Medication", getResult);
		}


	public record Parameters();
}