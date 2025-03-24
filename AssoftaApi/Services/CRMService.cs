using AssoftaApi.Database;
using AssoftaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace AssoftaApi.Services;

public class CRMService(AssoftaDbContext context)
{

    public async Task<string> SynchronisierungDurchfuehren()
    {
        return "Benutzerdaten erfolgreich synchronisiert.";
    }

}