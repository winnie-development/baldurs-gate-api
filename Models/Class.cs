using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Class : Entity, IAggregateRoot
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public Game Game { get; set; } 
}