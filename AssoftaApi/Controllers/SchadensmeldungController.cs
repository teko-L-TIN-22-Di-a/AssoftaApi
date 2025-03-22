using AssoftaApi.Database;
using AssoftaApi.Models;
using AssoftaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssoftaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class SchadensmeldungController(
    ILogger<SchadensmeldungController> logger, 
    SchadensmeldungService service) : ControllerBase
{
    [HttpPost(nameof(Create))]
    public async Task<IActionResult> Create(Schadensmeldung meldung)
    {
        await service.Add(meldung);
        return Ok();
    }

    [HttpPut(nameof(Put))]
    public async Task<IActionResult> Put(Schadensmeldung meldung)
    {
        await service.Edit(meldung);
        return Ok();
    }


    [HttpGet(nameof(GetEntschaedigung))]
    public async Task<double> GetEntschaedigung(string meldungId)
    {
        return await service.CalculateEntschaedigung(meldungId);
    }

    [HttpGet(nameof(GetAll))]
    public async Task<List<Schadensmeldung>> GetAll()
    {
        return await service.GetAll();
    }
}