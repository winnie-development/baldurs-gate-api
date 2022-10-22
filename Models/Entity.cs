using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Entity : IEntity, IAuditable
{
    [Required]
    [Key]
    public int Id { get; set; }
    
    [Required]
    public DateTime DateCreated { get; set; }
}

