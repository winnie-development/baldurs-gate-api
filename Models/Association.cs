using System.ComponentModel.DataAnnotations;

namespace BaldursGateAPI.Models;

public class Association : Entity
{
    [Required]
    public string Type { get; set; }
}