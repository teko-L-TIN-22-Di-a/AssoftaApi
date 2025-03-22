using AssoftaApi.Database;
using AssoftaApi.Models;
using AssoftaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssoftaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class BenutzerController(
    ILogger<BenutzerController> logger, 
    BenutzerService service) : ControllerBase
{
    [HttpPost(nameof(Create))]
    public async Task<IActionResult> Create(Benutzer benutzer)
    {
        await service.Add(benutzer);
        return Ok();
    }

    [HttpPut(nameof(Put))]
    public async Task<IActionResult> Put(Benutzer benutzer)
    {
        await service.Edit(benutzer);
        return Ok();
    }

    [HttpGet(nameof(GetAll))]
    public async Task<List<Benutzer>> GetAll()
    {
        return await service.GetAll();
    }
}