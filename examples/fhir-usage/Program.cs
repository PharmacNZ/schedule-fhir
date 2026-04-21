using System.CommandLine;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

using System.Text.Json;
using Microsoft.Extensions.Options;

namespace FhirUsage
{
  internal class Program
  {

		FhirClient client = new FhirClient("http://localhost:8080/fhir/r4");
    static int Main(string[] args)
    {

			// --search Medication, Rules
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


			// medication --medicationName
			Option<string[]> medicationNameOption = new ("--medicationName")
			{
				Description = "Search for Medication resources by name",
				AllowMultipleArgumentsPerToken = false,
			};

			Command medicationCommand = new("medication", "Search for Medication resources");
			medicationCommand.Options.Add(medicationNameOption);
			rootCommand.Subcommands.Add(medicationCommand);

			medicationCommand.SetAction(ParseResult => new Program().SearchMedicationByName(
				ParseResult.GetValue(medicationNameOption)?.FirstOrDefault() ?? string.Empty
			));

			// metadata
			Command metadataCommand = new("metadata", "Fetch FHIR server metadata");
			rootCommand.Subcommands.Add(metadataCommand);

			metadataCommand.SetAction(ParseResult => new Program().FetchMetadata());
			

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
      		//Console.WriteLine($"Received medication with {med?.Code?.Text}");
					var options = new JsonSerializerOptions { WriteIndented = true };
					string jsonString = JsonSerializer.Serialize(med, options);

					Console.WriteLine(jsonString);
					break;
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
  

	internal async Task<int> SearchMedicationByName(string medicationName)
		{
			if (string.IsNullOrEmpty(medicationName))
			{
				Console.WriteLine("Please provide a medication name using --medicationName");
				return 1;
			}

			var client = new FhirClient("http://localhost:8080/fhir/r4/");
			//var query = new SearchParams().Add("Code:Text", medicationName);
			/*var query = new SearchParams()
                .Where($"status=active")
                .LimitTo(10);*/
								//var query = new SearchParams();
        //query.Where($"code|text=Leuprorelin");
        //query.Add("_pretty", "true");
 var query = new SearchParams().Add("Code", $"text|{medicationName}");
        //var bundle = await client.SearchAsync<Medication>(searchParams);
			Bundle? searchResult = await client.SearchAsync<Medication>(query);
			foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
				{
					var med = result.Resource as Medication;
					Console.WriteLine($"Medication Name: {medicationName}");
					Console.WriteLine($"Received medication with {med?.Code?.Text}");
				}
			return 0;
		}

		internal async Task<int> FetchMetadata()
		{
			
			var metadata = await client.CapabilityStatementAsync();
			var options = new JsonSerializerOptions { WriteIndented = true };
			string jsonString = JsonSerializer.Serialize(metadata, options);

			Console.WriteLine(jsonString);
			return 0;
		}
	}
}
