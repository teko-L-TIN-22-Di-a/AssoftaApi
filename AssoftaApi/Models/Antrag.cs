﻿namespace AssoftaApi.Models;

public record Antrag
{
    public required string Id { get; set; }
    public required AntragStatus Status { get; set; }
    public required DateTime Date { get; set; }
    public required string BenutzerId { get; set; }

    public void Accept()
    {
        this.Status = AntragStatus.Accepted;
    }

    public void Decline()
    {
        this.Status = AntragStatus.Declined;
    }
}
