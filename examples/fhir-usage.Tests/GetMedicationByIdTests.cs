using Hl7.Fhir.Model;
using Moq;

public class GetMedicationByIdTests
{
    /// Tests for GetMedicationById action.
    [Fact]
    // Verifies that GetAsync is called with the correct URL when a valid ID is provided.
    public async System.Threading.Tasks.Task Execute_ValidId_CallsGetWithCorrectUrl()
    {
        var med = FhirTestHelpers.BuildMedication("med-123", "Paracetamol");
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync("Medication/med-123")).ReturnsAsync(med);

        var action = new GetMedicationById(mock.Object);
        await action.Execute(new GetMedicationById.Parameters("med-123"));

        mock.Verify(c => c.GetAsync("Medication/med-123"), Times.Once);
    }

    [Fact]
    // Verifies that when a Medication is found, its details are printed to the console.
    public async System.Threading.Tasks.Task Execute_FoundMedication_PrintsMedicationDetails()
    {
        var med = FhirTestHelpers.BuildMedication("med-42", "Leuprorelin");
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync("Medication/med-42")).ReturnsAsync(med);

        var action = new GetMedicationById(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetMedicationById.Parameters("med-42")).Wait());

        Assert.Contains("med-42", output);
    }

    [Fact]
    // Verifies that when a Medication is not found, a not found message is printed.
    public async System.Threading.Tasks.Task Execute_NotFound_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync(It.IsAny<string>())).ReturnsAsync((Resource?)null);

        var action = new GetMedicationById(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetMedicationById.Parameters("INVALID")).Wait());

        Assert.Contains("No Medication found.", output);
    }
}
