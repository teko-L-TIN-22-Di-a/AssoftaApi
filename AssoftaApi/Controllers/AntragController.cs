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