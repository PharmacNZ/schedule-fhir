using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;

public class GetMedicationById(FhirClient _client) : IAction<GetMedicationById.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetMedicationById action for resource with id: {parameters.Id}");

				//var query = new SearchParams().Add("status", "active");
				//var query = new SearchParams().Where($"Id:exact={parameters.Id}");
        //var bundle = await client.SearchAsync<Medication>(searchParams);
				// Bundle? searchResult = await _client.SearchAsync<Medication>(query);
				// foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				// {
				// 	var med = result.Resource as Medication;
				// 	Console.WriteLine($"Medication ID: {parameters.Id}");
				// 	Console.WriteLine($"Received medication with ID: {med?.Id}");
				// }
				var getResult = await _client.GetAsync($"Medication/{parameters.Id}") as Medication;
				if (getResult != null)
				{
					Console.WriteLine($"Medication ID: {parameters.Id}");
						Console.WriteLine($"Received medication with ID: {getResult?.Id}");
						Console.WriteLine($"Received medication with code: {getResult?.Code?.Text}");
				}
				

				HelperFunctions.PrintResultsCountFromUrl("Medication", getResult);
		}



	public record Parameters(string Id);
}