using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Alignment: Entity, IAggregateRoot
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public int Order { get; set; }
}