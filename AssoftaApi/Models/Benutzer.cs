namespace AssoftaApi.Models;

public record Benutzer
{
    public required string Id { get; set; }
    public required string Name { get; set; }
    public required string Adresse { get; set; }
    public required string Rolle { get; set; }
}
