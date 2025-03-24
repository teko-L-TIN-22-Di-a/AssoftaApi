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

    public async Task AcceptAntrag(string id)
    {
        try
        {
            context.AntragSet.First(x => x.Id == id).Accept();

            await context.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("Id nicht gefunden.");
        }
    }

    public async Task DeclineAntrag(string id)
    {
        try
        {
            context.AntragSet.First(x => x.Id == id).Decline();

            await context.SaveChangesAsync();
        }
        catch (Exception)
        {
            throw new Exception("Id nicht gefunden.");
        }
    }


    public async Task<List<Antrag>> GetAll()
    {
        return await context.AntragSet.ToListAsync();
    }

}