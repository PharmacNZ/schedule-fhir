using Hl7.Fhir.Model;

public class HelperFunctions
{
	public static void PrintResultsCountFromBundle(string resourceType, Bundle? searchResult)
	{
		bool isEmptyResult = searchResult?.Entry == null || searchResult?.Entry.Count == 0;
		if (isEmptyResult)			{
			Console.WriteLine($"No {resourceType} found.");
		}
		else
		{
			Console.WriteLine($"Returned {searchResult?.Entry?.Count ?? 0} {resourceType} results.");
		}
	}

	public static void PrintResultsCountFromUrl(string resourceType, object? getResult)
	{
		if (getResult == null)
		{
			Console.WriteLine($"No {resourceType} found.");
		}
		else
		{
			Console.WriteLine($"Returned {resourceType}.");
		}
	}
}