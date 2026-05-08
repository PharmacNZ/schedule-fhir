using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using System.Text.Json;
using Task = System.Threading.Tasks.Task;

public class GetMetadata(FhirClient _client) : IAction<GetMetadata.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting metadata
				Console.WriteLine("Executing GetMetadata action...");

				
			var metadata = await _client.CapabilityStatementAsync();
			var options = new JsonSerializerOptions { WriteIndented = true };
			string jsonString = JsonSerializer.Serialize(metadata, options);

			//Console.WriteLine(jsonString);
			File.WriteAllText("metadata.json", jsonString); // Text too long for terminal window, so write to file instead
			Console.WriteLine("Metadata written to metadata.json");
			
		}


	public record Parameters();
}