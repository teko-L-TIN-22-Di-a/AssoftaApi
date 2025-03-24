using AssoftaApi.Database;
using AssoftaApi.Models;
using AssoftaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssoftaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class AntragController(ILogger<AntragController> logger, AntragService service) : ControllerBase
{
    [HttpPost(nameof(Create))]
    public async Task<IActionResult> Create(Antrag antrag)
    {
        await service.Add(antrag);
        return Ok();
    }

    [HttpPost(nameof(Accept))]
    public async Task<IActionResult> Accept(string id)
    {
        await service.AcceptAntrag(id);
        return Ok();
    }

    [HttpPost(nameof(Decline))]
    public async Task<IActionResult> Decline(string id)
    {
        await service.DeclineAntrag(id);
        return Ok();
    }

    [HttpPut(nameof(Put))]
    public async Task<IActionResult> Put(Antrag antrag)
    {
        await service.Edit(antrag);
        return Ok();
    }

    [HttpGet(nameof(GetAll))]
    public async Task<List<Antrag>> GetAll()
    {
        return await service.GetAll();
    }
}