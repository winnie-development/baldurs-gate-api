using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Game: Entity, IAggregateRoot
{
    [Required]
    public string Name { get; set; }

    public ICollection<Character> Characters { get; set; } = new List<Character>();
}