using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Character : Entity, IAggregateRoot
{
    [Required]
    public string Name { get; set; }
    
    public string? ImageUrl { get; set; }
    
    public Alignment? Alignment { get; set; }
    
    public Class? Class { get; set; } 
    
    public Location? Location { get; set; }
    
    public AbilityScore? AbilityScore { get; set; }
    
    public Race? Race { get; set; }
    
    [Required]
    public Association Association { get; set; }
    
    [Required]
    public ICollection<Game> Games { get; } = new List<Game>();

}