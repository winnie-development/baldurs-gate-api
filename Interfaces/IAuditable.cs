namespace BaldursGateAPI.Interfaces;

public interface IAuditable
{
    DateTime DateCreated { get; set; }
    
    DateTime? DateModified { get; set; }
    
    DateTime? DateDeleted { get; set; }
}