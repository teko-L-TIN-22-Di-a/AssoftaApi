namespace AssoftaApi.Models;

public record Schadensmeldung
{
    public required string Id { get; set; }
    public required string Beschreibung { get; set; }
    public required DateTime Datum { get; set; }
    public required double Betrag { get; set; }
    public required double BenutzerId { get; set; }
}
