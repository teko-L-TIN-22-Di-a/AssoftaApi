using AssoftaApi.Database;
using AssoftaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssoftaApi.Services;

public class BenutzerService(AssoftaDbContext context)
{

    public async Task Add(Benutzer benutzer)
    {
        await context.BenutzerSet.AddAsync(benutzer);
        await context.SaveChangesAsync();
    }

    public async Task Edit(Benutzer benutzer)
    {
        context.BenutzerSet.Update(benutzer);
        await context.SaveChangesAsync();
    }

    public async Task<List<Benutzer>> GetAll()
    {
        return await context.BenutzerSet.ToListAsync();
    }

}