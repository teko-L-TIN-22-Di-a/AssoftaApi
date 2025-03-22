using AssoftaApi.Database;
using AssoftaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssoftaApi.Services;

public class AntragService(AssoftaDbContext context)
{

    public async Task Add(Antrag newAntrag)
    {
        await context.AntragSet.AddAsync(newAntrag);
        await context.SaveChangesAsync();
    }

    public async Task Edit(Antrag antrag)
    {
        context.AntragSet.Update(antrag);
        await context.SaveChangesAsync();
    }

    public async Task<List<Antrag>> GetAll()
    {
        return await context.AntragSet.ToListAsync();
    }

}