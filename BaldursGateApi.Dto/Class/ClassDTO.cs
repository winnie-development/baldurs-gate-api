using BaldursGateApi.Dto.Game;

namespace BaldursGateApi.Dto;

public class ClassDTO
{
    public string Name { get; set; }
    
    public List<GameDTO> Game { get; set; }
}