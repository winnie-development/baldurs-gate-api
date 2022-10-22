using System.Net;
using BaldursGateAPI.Dtos.Class;
using BaldursGateAPI.Services.Classes;
using Microsoft.AspNetCore.Mvc;

namespace BaldursGateAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ClassesController : ControllerBase
{
    private readonly IClassService _classService;

    public ClassesController(
        IClassService classService
    )
    {
        _classService = classService;
    }
    
    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<ClassDTO>))]
    public async Task<ActionResult<List<ClassDTO>>> GetClasses()
    {
        return await _classService.RetrieveAllClasses();
    }
}