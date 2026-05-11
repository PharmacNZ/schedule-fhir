using Hl7.Fhir.Model;
using System.Text;
using System.Text.Json;

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

	public static void DecodeBase64JsonExtensionKeepUnicode(string jsonBase64)
	{
			byte[] jsonBytes = Convert.FromBase64String(jsonBase64 ?? string.Empty);
		// this string will still have the \r\n and \u0022 values in it
		string jsonStringDecoded = Encoding.UTF8.GetString(jsonBytes);


		//Console.WriteLine(jsonStringDecoded);
		File.WriteAllText("JsonBase64Decoded.json", jsonStringDecoded); // Text too long for terminal window, so write to file instead
		Console.WriteLine("String written to JsonBase64Decoded.json");

	}

	public static void DecodeBase64JsonExtensionReplaceUnicode(string jsonBase64)
	{
		byte[] jsonBytes = Convert.FromBase64String(jsonBase64 ?? string.Empty);
		// this string will still have the \r\n and \u0022 values in it
		string jsonStringDecoded = Encoding.UTF8.GetString(jsonBytes);
		// this string has converted those to new lines and quotes
		string prettyJson = JsonSerializer.Serialize(JsonDocument.Parse(jsonStringDecoded), new JsonSerializerOptions { WriteIndented = true });

		//Console.WriteLine(prettyJson);
		File.WriteAllText("JsonBase64Decoded.json", prettyJson); // Text too long for terminal window, so write to file instead
		Console.WriteLine("String written to JsonBase64Decoded.json");

	}
}