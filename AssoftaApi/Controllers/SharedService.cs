using AssoftaApi.Database;
using AssoftaApi.Models;
using AssoftaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssoftaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SharedService(ILogger<SharedService> logger, FakturaService fakturaService, CRMService crmService, SchadensregulierungService damageService) : ControllerBase
{
    [HttpGet(nameof(StartBankabrechnung))]
    public async Task<string> StartBankabrechnung()
    {
        return await fakturaService.BankabrechnungDurchfuehren();
    }

    [HttpGet(nameof(StartCRMSynchronisierung))]
    public async Task<string> StartCRMSynchronisierung()
    {
        return await crmService.SynchronisierungDurchfuehren();
    }

    [HttpGet(nameof(StartSchadensregulierung))]
    public async Task<string> StartSchadensregulierung()
    {
        return await damageService.SchadensbewertungDurchfuehren();
    }
}