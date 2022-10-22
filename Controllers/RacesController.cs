using System.Net;
using BaldursGateAPI.Dtos.Race;
using BaldursGateAPI.Services.Race;
using Microsoft.AspNetCore.Mvc;

namespace BaldursGateAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class RacesController : ControllerBase
{
    private readonly IRaceService _raceService;

    public RacesController(
        IRaceService raceService
    )
    {
        _raceService = raceService;
    }
    
    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<RaceDTO>))]
    public async Task<ActionResult<List<RaceDTO>>> GetRaces()
    {
        return await _raceService.RetrieveAllRaces();
    }
}