using System.ComponentModel.DataAnnotations;

namespace BaldursGateAPI.Models;

public class Game: Entity
{
    [Required]
    public string Name;
}