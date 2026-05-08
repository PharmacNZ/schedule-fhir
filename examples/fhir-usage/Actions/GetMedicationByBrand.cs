using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;

public class GetMedicationByBrand(FhirClient _client) : IAction<GetMedicationByBrand.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by brand
				Console.WriteLine($"Executing GetByBrand action for resource with brand: {parameters.Brand}");

				var query = new SearchParams().Add("brand", parameters.Brand);
				//var query = new SearchParams().Where($"Id:exact={parameters.Id}");
        //var bundle = await client.SearchAsync<Medication>(searchParams);
				Bundle? searchResult = await _client.SearchAsync<Medication>(query);
				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var med = result.Resource as Medication;
					Console.WriteLine($"Medication Brand: {parameters.Brand}");
					Console.WriteLine($"Received medication with Brand: {med?.Extension?[0].Value}"); //Assumes brand is at index 0
				}

				HelperFunctions.PrintResultsCountFromBundle("Medication", searchResult);
		}



	public record Parameters(string Brand);
}