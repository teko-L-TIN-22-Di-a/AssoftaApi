using AssoftaApi.Database;
using AssoftaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssoftaApi.Services;

public class PoliceService(AssoftaDbContext context)
{

    public async Task Add(Police police)
    {
        await context.PoliceSet.AddAsync(police);
        await context.SaveChangesAsync();
    }

    public async Task Edit(Police police)
    {
        context.PoliceSet.Update(police);
        await context.SaveChangesAsync();
    }

    public async Task<List<Police>> GetAll()
    {
        return await context.PoliceSet.ToListAsync();
    }

}