using System.CommandLine;
using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;


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

			Option<string[]> categoryOption = new ("--category", new[] { "--c" })
			{
				Description = "Search for a resource by category, e.g. --category 'Special Foods'",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<string[]> lastUpdatedOption = new ("--lastUpdated", new[] { "--lu" })
			{
				Description = "Search for a resource by last updated date, e.g. --lastUpdated 2024-01-01",
				AllowMultipleArgumentsPerToken = false,
				Required = false,
			};

			Option<string[]> instanceOption = new ("--instance", new[] { "--ins" })
			{
				Description = "Search for a resource by instance, e.g. --instance Ricovir-Tenofovir",
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
			searchCommand.Options.Add(categoryOption);
			searchCommand.Options.Add(lastUpdatedOption);
			searchCommand.Options.Add(instanceOption);
			rootCommand.Subcommands.Add(searchCommand);
			searchCommand.SetAction(ParseResult => SearchResources(
				ParseResult.GetValue(resourceOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(nameOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(idOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(brandOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(decodeOption),
				ParseResult.GetValue(categoryOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(lastUpdatedOption)?.FirstOrDefault() ?? string.Empty,
				ParseResult.GetValue(instanceOption)?.FirstOrDefault() ?? string.Empty
				).Wait(
			));


			// metadata
			Command metadataCommand = new("metadata", "Fetch FHIR server metadata");
			rootCommand.Subcommands.Add(metadataCommand);

			metadataCommand.SetAction(ParseResult => new GetMetadata(new FhirClientAdapter(new FhirClient("http://localhost:8080/fhir/r4/"))).Execute(new GetMetadata.Parameters()).Wait());
			

			return rootCommand.Parse(args).Invoke();



    }

		internal static async Task<int> SearchResources(string resource, string name, string id, string brand, bool decode, string category, string lastUpdated, string instance)
		{
			IFhirClient client = new FhirClientAdapter(new FhirClient("http://localhost:8080/fhir/r4/"));
		
				Console.WriteLine($"Searching for resources of type {resource}...");
				//Console.WriteLine($"Search parameters - name: {name}, id: {id}, brand: {brand}, decode: {decode}, category: {category}, lastUpdated: {lastUpdated}, instance: {instance}");
				switch (resource)
				{
					case "Medication":
						if (!string.IsNullOrEmpty(name))
						{
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
						else if (!string.IsNullOrEmpty(category))
						{
							new GetMedicationByCategory(client).Execute(new GetMedicationByCategory.Parameters(category)).Wait();
						}
						else if (!string.IsNullOrEmpty(instance))
						{
							new GetAllCIDByInstance(client).Execute(new GetAllCIDByInstance.Parameters(instance)).Wait();
						}
						else
						{
							new GetAllMedications(client).Execute(new GetAllMedications.Parameters(lastUpdated)).Wait();
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
						} else if (!string.IsNullOrEmpty(instance))
						{
							new GetSAByInstance(client).Execute(new GetSAByInstance.Parameters(instance)).Wait();
						}
						else
						{
							new GetAllSpecialAuthorities(client).Execute(new GetAllSpecialAuthorities.Parameters(lastUpdated)).Wait();
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
						} else if (!string.IsNullOrEmpty(instance))
						{
							new GetFundingByInstance(client).Execute(new GetFundingByInstance.Parameters(instance)).Wait();
						}
						else
						{
							new GetAllFundingRules(client).Execute(new GetAllFundingRules.Parameters(lastUpdated)).Wait();
						}
						break;
						
					case "PricingRule":
						if (!string.IsNullOrEmpty(id))
						{
							new GetPricingRulesById(client).Execute(new GetPricingRulesById.Parameters(id)).Wait();
						} else if (!string.IsNullOrEmpty(instance))
						{
							new GetPricingByInstance(client).Execute(new GetPricingByInstance.Parameters(instance)).Wait();
						}
						else
						{
							new GetAllPricingRules(client).Execute(new GetAllPricingRules.Parameters(lastUpdated)).Wait();
						}
						break;
					default:
						Console.WriteLine("Currently no search method for resource type...");
						break;
				}
			
			return 0;
		}


}
}
