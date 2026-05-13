using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;

public class GetMedicationByCategory(IFhirClient _client) : IAction<GetMedicationByCategory.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by category
				Console.WriteLine($"Executing GetByCategory action for resource with category: {parameters.Category}");

				var query = new SearchParams().Add("category", parameters.Category);

				Bundle? searchResult = await _client.SearchAsync<Medication>(query);
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var med = result.Resource as Medication;
					Console.WriteLine($"Medication Input Category: {parameters.Category}");
					if (med?.GetExtension("https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1")?.Value?.ToString() == parameters.Category)
					{
						Console.WriteLine($"Received medication with code: {med?.Code?.Text}");
						Console.WriteLine($"Received medication with Category 1: {med?.GetExtension("https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-1")?.Value?.ToString()}");
					} else if (med?.GetExtension("https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2")?.Value?.ToString() == parameters.Category)
					{
						Console.WriteLine($"Received medication with code: {med?.Code?.Text}");
						Console.WriteLine($"Received medication with Category 2: {med?.GetExtension("https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-2")?.Value?.ToString()}");
					} else if (med?.GetExtension("https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3")?.Value?.ToString() == parameters.Category)
					{
						Console.WriteLine($"Received medication with code: {med?.Code?.Text}");
						Console.WriteLine($"Received medication with Category 3: {med?.GetExtension("https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/medication-atc-category-3")?.Value?.ToString()}");
					} else
					{
						Console.WriteLine($"Received medication with no matching category: {parameters.Category}");
					}
			
				}

				HelperFunctions.PrintResultsCountFromBundle("Medication", searchResult);
		}



	public record Parameters(string Category);
}