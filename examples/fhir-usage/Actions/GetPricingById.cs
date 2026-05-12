using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;
using System.Text.Json;

public class GetPricingRulesById(FhirClient _client) : IAction<GetPricingRulesById.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetPricingRulesById action for resource with pr: {parameters.Id}");

				string fullId = $"ChargeItemDefinition-{parameters.Id}";

				Console.WriteLine($"Constructed search query: {fullId}");

				var getResult = await _client.GetAsync($"ChargeItemDefinition/{fullId}") as ChargeItemDefinition;
				if (getResult != null)
				{
						Console.WriteLine($"Pricing Rule Id: {parameters.Id}");
						Console.WriteLine($"Received pricing rule with ID: {getResult?.Id}");
						Console.WriteLine($"Received pricing rule with description: {getResult?.PropertyGroup?[0]?.Applicability[0]?.Description}");
				}

				HelperFunctions.PrintResultsCountFromUrl("Pricing Rule", getResult);
		}


	public record Parameters(string Id);
}