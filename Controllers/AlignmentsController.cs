using System.Net;
using BaldursGateAPI.Dtos.Alignment;
using BaldursGateAPI.Services.Alignment;
using Microsoft.AspNetCore.Mvc;

namespace BaldursGateAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AlignmentsController : ControllerBase
{
    private readonly IAlignmentService _alignmentService;

    public AlignmentsController(
        IAlignmentService alignmentService
    )
    {
        _alignmentService = alignmentService;
    }
    
    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<AlignmentDTO>))]
    public async Task<ActionResult<List<AlignmentDTO>>> GetAlignments()
    {
        return await _alignmentService.RetrieveAllAlignments();
    }
}