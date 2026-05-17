using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;
using System.Text.Json;

public class GetSAByInstance(IFhirClient _client) : IAction<GetSAByInstance.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetSAByInstance action for special authorities with instance: {parameters.instance}");

				string fullInstance = $"Medication/Medication-{parameters.instance}";
				var query = new SearchParams().Add("instance.reference", fullInstance)
					.Add("_profile", "https://fhir-ig.digital.health.nz/pharmac-schedules/StructureDefinition/pharmac-charge-item-definition-special-authority");

				Bundle? searchResult = await _client.SearchAsync<ChargeItemDefinition>(query);

				foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))

				{
					var cid = result.Resource as ChargeItemDefinition;
					Console.WriteLine($"Charge Item Definition Instance: {parameters.instance}");
					Console.WriteLine($"Received SA with Id: {cid?.Id}"); 

				}

				HelperFunctions.PrintResultsCountFromBundle("Special Authority", searchResult);
		}



	public record Parameters(string instance);
}