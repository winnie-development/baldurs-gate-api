using System.ComponentModel.DataAnnotations;

namespace BaldursGateAPI.Models;

public class Location : Entity
{
    [Required]
    public string Name { get; set; }
    
    [Required]
    public string AreaCode { get; set; }

    [Required] 
    public Game Game { get; set; }
}