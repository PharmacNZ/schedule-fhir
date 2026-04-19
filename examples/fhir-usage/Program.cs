using System.CommandLine;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

using System.Text.Json;

namespace FhirUsage
{
  internal class Program
  {

		FhirClient client = new FhirClient("http://localhost:8080/fhir/r4");
    static int Main(string[] args)
    {
			Option<string[]> searchResourceOption = new ("--search")
			{
				Description = "Search for a resource type, e.g. --search Medication",
				AllowMultipleArgumentsPerToken = false,
			};

			RootCommand rootCommand = new("Sample app for FHIR client usage");
			rootCommand.Options.Add(searchResourceOption);

			rootCommand.SetAction(ParseResult => SearchResources(
				ParseResult.GetValue(searchResourceOption)?.FirstOrDefault() ?? string.Empty
			));

			return rootCommand.Parse(args).Invoke();

      /*var client = new FhirClient("http://localhost:8080/fhir/r4");
       //client.Create(patient);
       Bundle? searchResult = await client.SearchAsync<Medication>();

       foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
       {
         var med = result.Resource as Medication;
         Console.WriteLine($"Received medication with {med?.Code?.Text}");
       }*/

    }

		internal static async Task<int> SearchResources(string resourceType)
		{
			//var client = new FhirClient("http://localhost:8080/fhir/r4");
		
				Console.WriteLine($"Searching for resources of type {resourceType}...");
				switch (resourceType)
				{
					case "Medication":
						await new Program().SearchMedication();
						break;
					case "Rules":
						await new Program().SearchRules();
						break;
					default:
						Console.WriteLine("Currently no search method for resource type...");
						break;
				}
			
			return 0;
		}

		internal async Task<int> SearchMedication()
		{
			Bundle? searchResult = await this.client.SearchAsync<Medication>();
			foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var med = result.Resource as Medication;
      		Console.WriteLine($"Received medication with {med?.Code?.Text}");
					/*var options = new JsonSerializerOptions { WriteIndented = true };
					string jsonString = JsonSerializer.Serialize(med, options);

					Console.WriteLine(jsonString);
					break;*/
				}
			return 0;
		}

		internal async Task<int> SearchRules()
		{
			Bundle? searchResult = await this.client.SearchAsync<ChargeItemDefinition>();
			foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var rule = result.Resource as ChargeItemDefinition;
					//Console.WriteLine($"Received pricing with {rule?.Applicability?[0].Description}");
					Console.WriteLine($"Received rule with {rule?.Id}");

					/*var options = new JsonSerializerOptions { WriteIndented = true };
					string jsonString = JsonSerializer.Serialize(rule, options);

					Console.WriteLine(jsonString);
					break;*/
				}
			return 0;
		}
  }
}
