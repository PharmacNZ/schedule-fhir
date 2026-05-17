using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;
using System.Text.Json;

public class GetAllCIDByInstance(IFhirClient _client) : IAction<GetAllCIDByInstance.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetAllCIDByInstance action for resource with instance: {parameters.instance}");

				string fullInstance = $"Medication/Medication-{parameters.instance}";
				var query = new SearchParams().Add("instance.reference", fullInstance);

				Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);

				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))

				{
					var cid = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Charge Item Definition Instance: {parameters.instance}");
					Console.WriteLine($"Received CID with Id: {cid?.Id}"); 
					
				}

				HelperFunctions.PrintResultsCountFromBundle("Charge Item Definition", searchResult);
		}



	public record Parameters(string instance);
}