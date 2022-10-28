using BaldursGateAPI.Dtos.Game;
using BaldursGateAPI.Dtos.Race;

namespace BaldursGateAPI.Dtos.Character;

public class CharacterDto
{
    public string Name { get; set; } = default!;
    public string ImageUrl { get; set; } = default!;
    public AbilityScoreDto AbilityScore { get; set; } = default!;
    public string Alignment { get; set; } = default!;
    public string Race { get; set; } = default!;
}