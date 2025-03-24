using AssoftaApi.Database;
using AssoftaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssoftaApi.Services;

public class SchadensmeldungService(AssoftaDbContext context)
{

    public async Task Add(Schadensmeldung meldung)
    {
        await context.SchadensmeldungsSet.AddAsync(meldung);
        await context.SaveChangesAsync();
    }

    public async Task Edit(Schadensmeldung meldung)
    {
        context.SchadensmeldungsSet.Update(meldung);
        await context.SaveChangesAsync();
    }

    public async Task<string> SchadensmeldungPruefen(string meldungId)
    {
        Random rand = new Random();
        return rand.Next(2) == 0 ? "Erlaubt" : "Abgelehnt";
    }


    public async Task<double> CalculateEntschaedigung(string meldungId)
    {
        var meldung = await context.SchadensmeldungsSet.FindAsync(meldungId);
        if (meldung == null)
        {
            throw new Exception($"meldung {meldungId} not found");
        }

        // Magic go do aahhhhh
        return Random.Shared.NextDouble() * 32 * meldung.Betrag;
    }

    public async Task<List<Schadensmeldung>> GetAll()
    {
        return await context.SchadensmeldungsSet.ToListAsync();
    }

}