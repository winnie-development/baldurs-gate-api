using BaldursGateAPI.Dtos.Class;
using BaldursGateAPI.Helpers;
using BaldursGateAPI.Services.Classes;
using Microsoft.EntityFrameworkCore;

namespace BaldursGateAPI.Services.Class;

public class ClassService : IClassService
{
    private readonly DataContext _context;

    public ClassService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<ClassDTO>> RetrieveAllClasses()
    {
        var races = await _context.Classes.Include(e => e.Game).AsNoTracking().ToListAsync();
        return races.Select(c => new ClassDTO
        {
            Class = c.Name,
            Game = c.Game.Name
        }).ToList();
    }
}