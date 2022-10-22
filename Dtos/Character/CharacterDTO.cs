using BaldursGateAPI.Dtos.Game;
using BaldursGateAPI.Dtos.Race;

namespace BaldursGateAPI.Dtos.Character;

public class CharacterDTO
{
    public string Name { get; set; }
    
    public string ImageUrl { get; set; }
    public AbilityScoreDTO AbilityScore { get; set; }
    public string Alignment { get; set; }
    public string Race { get; set; }
}