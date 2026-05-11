using Hl7.Fhir.Rest;
using Hl7.Fhir.Model;
using Task = System.Threading.Tasks.Task;
using System.Text.Json;

public class GetFundingRulesById(FhirClient _client) : IAction<GetFundingRulesById.Parameters>
{
		public async Task Execute(Parameters parameters)
		{
				// Implementation for getting a resource by id
				Console.WriteLine($"Executing GetFundingRulesById action for resource with fr: {parameters.Id}");

				string fullId = $"ChargeItemDefinition-{parameters.Id}";

				Console.WriteLine($"Constructed search query: {fullId}");

				var getResult = await _client.GetAsync($"ChargeItemDefinition/{fullId}") as ChargeItemDefinition;
				if (getResult != null)
				{
						Console.WriteLine($"Funding Rule Id: {parameters.Id}");
						Console.WriteLine($"Received funding rule with ID: {getResult?.Id}");
						Console.WriteLine($"Received funding rule with description: {getResult?.PropertyGroup?[0]?.Applicability[0]?.Description}");
				}

				HelperFunctions.PrintResultsCountFromUrl("Funding Rule", getResult);
		}


	public record Parameters(string Id);
}