using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;

public class GetMedicationById(IFhirClient _client) : IAction<GetMedicationById.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetMedicationById action for resource with id: {parameters.Id}");

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