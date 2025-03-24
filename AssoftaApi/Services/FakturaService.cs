using AssoftaApi.Database;
using AssoftaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssoftaApi.Services;

public class FakturaService(AssoftaDbContext context)
{

    public async Task<string> BankabrechnungDurchfuehren()
    {
        return "Die Übertragung der Daten wurde erfolgreich durchgeführt.";
    }

}