namespace AssoftaApi.Models;

public record Police
{
    public required string Id { get; set; }
    public required DateTime Beginn { get; set; }
    public required DateTime Ende { get; set; }
    public required double Praemie { get; set; }
    public required string BenutzerId { get; set; }
}
