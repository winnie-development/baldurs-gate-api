using BaldursGateAPI.Dtos.Character;

namespace BaldursGateAPI.Services.Character;

public interface ICharacterService
{
    Task<List<CharacterDto>> RetrieveAllCharacters();
}