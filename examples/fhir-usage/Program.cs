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
			// --resource Medication (--name Leuprorelin || --id 123)

			// --resource Medication, Rules
			Option<string[]> resourceOption = new ("--resource", new[] { "--r" })
			{
				Description = "Search for a resource type, e.g. --resource Medication",
				AllowMultipleArgumentsPerToken = false,
				Required = true,
			};

			Option<string[]> nameOption = new ("--name", new[] { "--n" })
			{
				Description = "Search for a resource by name, e.g. --name Leuprorelin",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<string[]> idOption = new ("--id", new[] { "--i" })
			{
				Description = "Search for a resource by id, e.g. --id 123",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<string[]> brandOption = new ("--brand", new[] { "--b" })
			{
				Description = "Search for a resource by brand, e.g. --brand Ricovir",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			// Option<string[]> codeOption = new ("--code", new[] { "--c" })
			// {
			// 	Description = "Search for a resource by code, e.g. --code SA1234",
			// 	AllowMultipleArgumentsPerToken = false,
			// 	Required = false,
			// };

			RootCommand rootCommand = new("Sample app for FHIR client usage");

			// search
			Command searchCommand = new("search", "Search for FHIR resources");
			searchCommand.Options.Add(resourceOption);
			searchCommand.Options.Add(nameOption);
			searchCommand.Options.Add(idOption);
			searchCommand.Options.Add(brandOption);
			//searchCommand.Options.Add(codeOption);
			rootCommand.Subcommands.Add(searchCommand);
			searchCommand.SetAction(ParseResult => SearchResources(
				ParseResult.GetValue(resourceOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(nameOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(idOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(brandOption)?.FirstOrDefault() ?? string.Empty//,
				//ParseResult.GetValue(codeOption)?.FirstOrDefault() ?? string.Empty
			));

			// metadata
			Command metadataCommand = new("metadata", "Fetch FHIR server metadata");
			rootCommand.Subcommands.Add(metadataCommand);

			metadataCommand.SetAction(ParseResult => new GetMetadata(new FhirClient("http://localhost:8080/fhir/r4/")).Execute(new GetMetadata.Parameters()).Wait());
			

			return rootCommand.Parse(args).Invoke();



    }

		internal static async Task<int> SearchResources(string resource, string name, string id, string brand/*, string code*/)
		{
			var client = new FhirClient("http://localhost:8080/fhir/r4/");
		
				Console.WriteLine($"Searching for resources of type {resource}...");
				switch (resource)
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
					case "SpecialAuthority":
						if (!string.IsNullOrEmpty(id))
						{
							new GetSAById(client).Execute(new GetSAById.Parameters(id)).Wait();
						}
						else
						{
							new GetAllSAs(client).Execute(new GetAllSAs.Parameters()).Wait();
						}
						break;
					default:
						Console.WriteLine("Currently no search method for resource type...");
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
  

	

		
	}
}
