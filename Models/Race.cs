using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Race: Entity, IAggregateRoot
{
    [Required]
    public string CharacterRace { get; set; }
    
    [Required]
    public Game Game { get; set; }
}