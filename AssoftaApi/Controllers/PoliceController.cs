using AssoftaApi.Database;
using AssoftaApi.Models;
using AssoftaApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace AssoftaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class PoliceController(
    ILogger<PoliceController> logger, 
    PoliceService service) : ControllerBase
{
    [HttpPost(nameof(Create))]
    public async Task<IActionResult> Create(Police police)
    {
        await service.Add(police);
        return Ok();
    }

    [HttpPut(nameof(Put))]
    public async Task<IActionResult> Put(Police police)
    {
        await service.Edit(police);
        return Ok();
    }


    [HttpGet(nameof(GetAll))]
    public async Task<List<Police>> GetAll()
    {
        return await service.GetAll();
    }
}