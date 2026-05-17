using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;

public class GetMedicationByName(IFhirClient _client) : IAction<GetMedicationByName.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by name
				Console.WriteLine($"Executing GetByName action for resource with name: {parameters.Name}");

				var query = new SearchParams().Add("name", parameters.Name);
				Bundle? searchResult = await _client.SearchAsync<Medication>(query);
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var med = result.Resource as Medication;
					Console.WriteLine($"Medication Name: {parameters.Name}");
					Console.WriteLine($"Received medication with name: {med?.Code?.Text}");
				}

				HelperFunctions.PrintResultsCountFromBundle("Medication", searchResult);
		}



	public record Parameters(string Name);
}