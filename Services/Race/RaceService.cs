using BaldursGateAPI.Dtos.Race;
using BaldursGateAPI.Helpers;
using Microsoft.EntityFrameworkCore;

namespace BaldursGateAPI.Services.Race;

public class RaceService : IRaceService
{
    private readonly DataContext _context;

    public RaceService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<RaceDTO>> RetrieveAllRaces()
    {
        var races = await _context.Races.AsNoTracking().ToListAsync();
        return races.Select(r => new RaceDTO
        {
            Race = r.CharacterRace
        }).ToList();
    }
}