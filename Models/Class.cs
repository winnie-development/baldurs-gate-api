using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Class : Entity, IAggregateRoot
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public ICollection<Game> Games { get; } = new List<Game>();
}