using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Race: Entity, IAggregateRoot
{
    [Required]
    public string CharacterRace { get; set; }
    
    [Required]
    public ICollection<Game> Games { get; } = new List<Game>();
}