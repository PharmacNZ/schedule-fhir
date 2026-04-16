using Hl7.Fhir.Model;
using Hl7.Fhir.Rest;

namespace MyFirstFhirClient
{
  internal class Program
  {
    static async System.Threading.Tasks.Task Main(string[] args)
    {
      var client = new FhirClient("http://localhost:8080/fhir/r4");
       //client.Create(patient);
       Bundle? searchResult = await client.SearchAsync<Medication>();

       foreach (var result in (searchResult?.Entry ?? Enumerable.Empty<Bundle.EntryComponent>()))
       {
         var med = result.Resource as Medication;
         Console.WriteLine($"Received medication with {med?.Code?.Text}");
       }

    }
  }
}
