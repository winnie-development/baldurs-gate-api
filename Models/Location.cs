using System.ComponentModel.DataAnnotations;

namespace BaldursGateAPI.Models;

public class Location : Entity
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string AreaCode { get; set; }
    
    [Required]
    public ICollection<Game> Games { get; } = new List<Game>();
}