using Hl7.Fhir.Model;
using System.IO;

public class HelperFunctionsTests
{
    // Helper to capture Console.WriteLine output
    private static string CaptureConsoleOutput(Action action)
    {
        var sw = new StringWriter();
        var original = Console.Out;
        Console.SetOut(sw);
        try { action(); }
        finally { Console.SetOut(original); }
        return sw.ToString();
    }

    // --- PrintResultsCountFromBundle ---

    [Fact]
    public void PrintResultsCountFromBundle_NullBundle_PrintsNotFound()
    {
        var output = CaptureConsoleOutput(() =>
            HelperFunctions.PrintResultsCountFromBundle("Medication", null));

        Assert.Contains("No Medication found.", output);
    }

    [Fact]
    public void PrintResultsCountFromBundle_EmptyEntries_PrintsNotFound()
    {
        var bundle = new Bundle { Entry = [] };

        var output = CaptureConsoleOutput(() =>
            HelperFunctions.PrintResultsCountFromBundle("Medication", bundle));

        Assert.Contains("No Medication found.", output);
    }

    [Fact]
    public void PrintResultsCountFromBundle_WithEntries_PrintsCount()
    {
        var bundle = new Bundle
        {
            Entry =
            [
                new Bundle.EntryComponent { Resource = new Medication() },
                new Bundle.EntryComponent { Resource = new Medication() },
            ]
        };

        var output = CaptureConsoleOutput(() =>
            HelperFunctions.PrintResultsCountFromBundle("Medication", bundle));

        Assert.Contains("2 Medication results.", output);
    }

    [Fact]
    public void PrintResultsCountFromBundle_SingleEntry_PrintsCount()
    {
        var bundle = new Bundle
        {
            Entry = [new Bundle.EntryComponent { Resource = new ChargeItemDefinition() }]
        };

        var output = CaptureConsoleOutput(() =>
            HelperFunctions.PrintResultsCountFromBundle("Special Authority", bundle));

        Assert.Contains("1 Special Authority results.", output);
    }

    // --- PrintResultsCountFromUrl ---

    [Fact]
    public void PrintResultsCountFromUrl_NullResult_PrintsNotFound()
    {
        var output = CaptureConsoleOutput(() =>
            HelperFunctions.PrintResultsCountFromUrl("Medication", null));

        Assert.Contains("No Medication found.", output);
    }

    [Fact]
    public void PrintResultsCountFromUrl_WithResult_PrintsReturned()
    {
        var output = CaptureConsoleOutput(() =>
            HelperFunctions.PrintResultsCountFromUrl("Medication", new Medication()));

        Assert.Contains("Returned Medication.", output);
    }

    // --- DecodeBase64JsonExtensionKeepUnicode ---

    [Fact]
    public void DecodeBase64JsonExtensionKeepUnicode_ValidBase64_WritesFile()
    {
        var json = "{\"key\": \"value\"}";
        var base64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json));
        var outputPath = "JsonBase64Decoded.json";

        if (File.Exists(outputPath)) File.Delete(outputPath);

        var consoleOutput = CaptureConsoleOutput(() =>
            HelperFunctions.DecodeBase64JsonExtensionKeepUnicode(base64));

        Assert.True(File.Exists(outputPath));
        Assert.Contains("String written to JsonBase64Decoded.json", consoleOutput);
        var written = File.ReadAllText(outputPath);
        Assert.Contains("value", written);

        File.Delete(outputPath);
    }

    // --- DecodeBase64JsonExtensionReplaceUnicode ---

    [Fact]
    public void DecodeBase64JsonExtensionReplaceUnicode_ValidBase64_WritesFormattedJson()
    {
        var json = "{\"key\":\"value\"}";
        var base64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json));
        var outputPath = "JsonBase64Decoded.json";

        if (File.Exists(outputPath)) File.Delete(outputPath);

        var consoleOutput = CaptureConsoleOutput(() =>
            HelperFunctions.DecodeBase64JsonExtensionReplaceUnicode(base64));

        Assert.True(File.Exists(outputPath));
        Assert.Contains("String written to JsonBase64Decoded.json", consoleOutput);
        var written = File.ReadAllText(outputPath);
        Assert.Contains("value", written);

        File.Delete(outputPath);
    }
}
