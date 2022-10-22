using System.Net;
using BaldursGateAPI.Dtos.Character;
using BaldursGateAPI.Services.Character;
using Microsoft.AspNetCore.Mvc;

namespace BaldursGateAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CharactersController : ControllerBase
{
    private readonly ICharacterService _characterService;

    public CharactersController(
        ICharacterService characterService
    )
    {
        _characterService = characterService;
    }
    
    [HttpGet]
    [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(List<CharacterDTO>))]
    public async Task<ActionResult<List<CharacterDTO>>> GetAlignments()
    {
        return await _characterService.RetrieveAllCharacters();
    }
}