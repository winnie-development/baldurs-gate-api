using BaldursGateApi.Dto.Game;

namespace BaldursGateApi.Dto.Character;

public class CharacterDTO
{
    public string Name { get; set; }
    
    public string ImageUrl { get; set; }
    
    public Guid AssociationId { get; set; }

    public Guid AbilityScoreId { get; set; }
    
    public Guid AlignmentId { get; set; }
    
    public Guid ClassId { get; set; }
    
    public Guid LocationId { get; set; }
    
    public Guid RaceId { get; set; }

    public List<GameDTO> Game { get; set; }

}