using BaldursGateAPI.Interfaces;

namespace BaldursGateAPI.Models;

public class AbilityScore : Entity, IAggregateRoot
{
    public string Strength { get; set; }
    
    public int Dexterity { get; set; }
    
    public int Constitution { get; set; }
    
    public int Intelligence { get; set; }
    
    public int Wisdom { get; set; }
    
    public int Charisma { get; set; }
    
    public int Total { get; set; }
}