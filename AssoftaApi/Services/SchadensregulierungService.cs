using AssoftaApi.Database;
using AssoftaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssoftaApi.Services;

public class SchadensregulierungService(AssoftaDbContext context)
{

    public async Task<string> SchadensbewertungDurchfuehren()
    {
        return "Wow, much damage, very costly";
    }

}