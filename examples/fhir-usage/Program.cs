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
			// search options

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
				Description = "Search for a resource by id, e.g. --id SA9999",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<string[]> brandOption = new ("--brand", new[] { "--b" })
			{
				Description = "Search for a resource by brand, e.g. --brand Ricovir",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<bool> decodeOption = new ("--authSchema", new[] { "--a" })
			{
				Description = "Decode the authorization schema of the result, e.g. --authSchema",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};


			RootCommand rootCommand = new("Sample app for FHIR client usage");

			// search
			Command searchCommand = new("search", "Search for FHIR resources");
			searchCommand.Options.Add(resourceOption);
			searchCommand.Options.Add(nameOption);
			searchCommand.Options.Add(idOption);
			searchCommand.Options.Add(brandOption);
			searchCommand.Options.Add(decodeOption);
			rootCommand.Subcommands.Add(searchCommand);
			searchCommand.SetAction(ParseResult => SearchResources(
				ParseResult.GetValue(resourceOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(nameOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(idOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(brandOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(decodeOption)

			));


			// bulk exports
			Command exportCommand = new("export", "Perform bulk export of FHIR resources");
			exportCommand.Options.Add(resourceOption);
			rootCommand.Subcommands.Add(exportCommand);
			exportCommand.SetAction(ParseResult => ExportResources(ParseResult.GetValue(resourceOption)?.FirstOrDefault() ?? string.Empty));

			// metadata
			Command metadataCommand = new("metadata", "Fetch FHIR server metadata");
			rootCommand.Subcommands.Add(metadataCommand);

			metadataCommand.SetAction(ParseResult => new GetMetadata(new FhirClient("http://localhost:8080/fhir/r4/")).Execute(new GetMetadata.Parameters()).Wait());
			

			return rootCommand.Parse(args).Invoke();



    }

		internal static async Task<int> SearchResources(string resource, string name, string id, string brand, bool decode)
		{
			var client = new FhirClient("http://localhost:8080/fhir/r4/");
		
				Console.WriteLine($"Searching for resources of type {resource}...");
				//Console.WriteLine($"Search parameters - name: {name}, id: {id}, brand: {brand}, decode: {decode}");
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
							if (decode)
							{
								//get sa by id and decode auth schema
								new GetSAAuthSchema(client).Execute(new GetSAAuthSchema.Parameters(id)).Wait();
							} 
							else
							{
								new GetSAById(client).Execute(new GetSAById.Parameters(id)).Wait();
							}
						}
						else
						{
							new GetAllSpecialAuthorities(client).Execute(new GetAllSpecialAuthorities.Parameters()).Wait();
						}
						break;
					case "FundingRule":
						if (!string.IsNullOrEmpty(id))
						{
							if (decode)
							{
								//get funding rule by id and decode auth schema
								new GetFundingAuthSchema(client).Execute(new GetFundingAuthSchema.Parameters(id)).Wait();
							}
							else
							{
								new GetFundingRulesById(client).Execute(new GetFundingRulesById.Parameters(id)).Wait();
							}
						}
						else
						{
							new GetAllFundingRules(client).Execute(new GetAllFundingRules.Parameters()).Wait();
						}
						break;
						
					case "PricingRule":
						
							new GetAllPricingRules(client).Execute(new GetAllPricingRules.Parameters()).Wait();
						break;
					default:
						Console.WriteLine("Currently no search method for resource type...");
						break;
				}
			
			return 0;
		}

	

		internal static async Task<int> ExportResources(string resource)
		{
			var client = new FhirClient("http://localhost:8080/fhir/r4/");
				Console.WriteLine($"Exporting resources of type {resource}...");

				switch (resource)
				{
					case "Medication":

							new GetAllMedications(client).Execute(new GetAllMedications.Parameters()).Wait();
							//new ExportMedications(client).Execute(new ExportMedications.Parameters()).Wait();

						break;
					case "SpecialAuthority":

							new GetAllSpecialAuthorities(client).Execute(new GetAllSpecialAuthorities.Parameters()).Wait();
						
						break;
					case "ChargeItemDefinition":

							new GetAllChargeItemDefinitions(client).Execute(new GetAllChargeItemDefinitions.Parameters()).Wait();
						
						break;
					case "FundingRule":

							new GetAllFundingRules(client).Execute(new GetAllFundingRules.Parameters()).Wait();
						
						break;
					case "PricingRule":

							new GetAllPricingRules(client).Execute(new GetAllPricingRules.Parameters()).Wait();
						
						break;
					case "All":

							new GetAllMedications(client).Execute(new GetAllMedications.Parameters()).Wait();

						
						break;
					default:
						Console.WriteLine("Currently no search method for resource type...");
						break;
				}
			
			return 0;
	}
}
}
