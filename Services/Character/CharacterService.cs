using BaldursGateAPI.Dtos;
using BaldursGateAPI.Dtos.Character;
using BaldursGateAPI.Dtos.Race;
using BaldursGateAPI.Helpers;
using Microsoft.EntityFrameworkCore;

namespace BaldursGateAPI.Services.Character;

public class CharacterService : ICharacterService
{
    private readonly DataContext _context;

    public CharacterService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<CharacterDTO>> RetrieveAllCharacters()
    {
        var characters = await _context.Characters
            .Include(e => e.AbilityScore)
            .Include(a => a.Race)
            .Include(c => c.Alignment)
            .AsNoTracking()
            .ToListAsync();
        
        return characters.Select(c => new CharacterDTO
        {
            Name = c.Name,
            ImageUrl = c.ImageUrl,
            AbilityScore = new AbilityScoreDTO
            {
                Strength = c.AbilityScore.Strength,
                Dexterity = c.AbilityScore.Dexterity,
                Constitution = c.AbilityScore.Constitution,
                Intelligence = c.AbilityScore.Intelligence,
                Wisdom = c.AbilityScore.Wisdom,
                Charisma = c.AbilityScore.Charisma,
                Total = c.AbilityScore.Total
            },
            Race = c.Race.CharacterRace,
            Alignment = c.Alignment.Name
        }).ToList();
    }
}