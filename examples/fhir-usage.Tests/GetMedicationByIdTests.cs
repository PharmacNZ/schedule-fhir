using Hl7.Fhir.Model;
using Moq;

public class GetMedicationByIdTests
{
    [Fact]
    public async System.Threading.Tasks.Task Execute_ValidId_CallsGetWithCorrectUrl()
    {
        var med = FhirTestHelpers.BuildMedication("med-123", "Paracetamol"); //TODO: change input?
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync("Medication/med-123")).ReturnsAsync(med);

        var action = new GetMedicationById(mock.Object);
        await action.Execute(new GetMedicationById.Parameters("med-123"));

        mock.Verify(c => c.GetAsync("Medication/med-123"), Times.Once);
    }

    [Fact]
    public async System.Threading.Tasks.Task Execute_FoundMedication_PrintsMedicationDetails()
    {
        var med = FhirTestHelpers.BuildMedication("med-42", "Leuprorelin"); //TODO: change input?
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync("Medication/med-42")).ReturnsAsync(med);

        var action = new GetMedicationById(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetMedicationById.Parameters("med-42")).Wait());

        Assert.Contains("med-42", output);
    }

    [Fact]
    public async System.Threading.Tasks.Task Execute_NotFound_PrintsNotFound()
    {
        var mock = new Mock<IFhirClient>();
        mock.Setup(c => c.GetAsync(It.IsAny<string>())).ReturnsAsync((Resource?)null);

        var action = new GetMedicationById(mock.Object);
        var output = FhirTestHelpers.CaptureConsoleOutput(() =>
            action.Execute(new GetMedicationById.Parameters("unknown")).Wait());

        Assert.Contains("No Medication found.", output);
    }
}
