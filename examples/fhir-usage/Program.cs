using System.CommandLine;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

using System.Text.Json;
using Microsoft.Extensions.Options;
//using Microsoft.Extensions.Options;
//using Newtonsoft.Json;

namespace FhirUsage
{
  internal class Program
  {

		FhirClient client = new FhirClient("http://localhost:8080/fhir/r4");
    static int Main(string[] args)
    {
			// --search Medication (--name Leuprorelin || --id 123)

			// --search Medication, Rules
			Option<string[]> searchResourceOption = new ("--search", new[] { "-s" })
			{
				Description = "Search for a resource type, e.g. --search Medication",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<string[]> nameOption = new ("--name", new[] { "-n" })
			{
				Description = "Search for a resource by name, e.g. --name Leuprorelin",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<string[]> idOption = new ("--id", new[] { "-i" })
			{
				Description = "Search for a resource by id, e.g. --id 123",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<string[]> brandOption = new ("--brand", new[] { "-b" })
			{
				Description = "Search for a resource by brand, e.g. --brand Ricovir",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			RootCommand rootCommand = new("Sample app for FHIR client usage");
			rootCommand.Options.Add(searchResourceOption);
			rootCommand.Options.Add(nameOption);
			rootCommand.Options.Add(idOption);
			rootCommand.Options.Add(brandOption);
			rootCommand.SetAction(ParseResult => SearchResources(
				ParseResult.GetValue(searchResourceOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(nameOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(idOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(brandOption)?.FirstOrDefault() ?? string.Empty
			));



			// metadata
			Command metadataCommand = new("metadata", "Fetch FHIR server metadata");
			rootCommand.Subcommands.Add(metadataCommand);

			metadataCommand.SetAction(ParseResult => new GetMetadata(new FhirClient("http://localhost:8080/fhir/r4/")).Execute(new GetMetadata.Parameters()).Wait());
			

			return rootCommand.Parse(args).Invoke();



    }

		internal static async Task<int> SearchResources(string resourceType, string name, string id, string brand)
		{
			var client = new FhirClient("http://localhost:8080/fhir/r4/");
		
				Console.WriteLine($"Searching for resources of type {resourceType}...");
				switch (resourceType)
				{
					case "Medication":
						if (!string.IsNullOrEmpty(name))
						{
							//await new Program().SearchMedicationByName(name);
							new GetMedicationByName(client).Execute(new GetMedicationByName.Parameters(name)).Wait();
						}
						else if (!string.IsNullOrEmpty(id))
						{
							new GetMedicationById(client).Execute(new GetMedicationById.Parameters(id)).Wait();
						}
						else if (!string.IsNullOrEmpty(brand))
						{
							new GetMedicationByBrand(client).Execute(new GetMedicationByBrand.Parameters(brand)).Wait();
						}
						else
						{
							//await new Program().SearchAllMedication();
							new GetAllMedications(client).Execute(new GetAllMedications.Parameters()).Wait();
						}
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

	

		internal async Task<int> SearchAllMedication()
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

			//Console.WriteLine(jsonString);
			File.WriteAllText("metadata.json", jsonString);
			return 0;
		}
	}
}
