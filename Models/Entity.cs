using System.ComponentModel.DataAnnotations;
using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class Entity : IEntity, IAuditable
{
    protected Entity()
    {
        Id = Guid.NewGuid();
    }
    [Required]
    [Key]
    public Guid Id { get; set; }
    
    [Required]
    public DateTime DateCreated { get; set; }

    public DateTime? DateModified { get; set; }
    
    public DateTime? DateDeleted { get; set; }
}

