using BaldursGateAPI.Dtos.Alignment;
using BaldursGateAPI.Helpers;
using Microsoft.EntityFrameworkCore;

namespace BaldursGateAPI.Services.Alignment;

public class AlignmentService : IAlignmentService
{
    private readonly DataContext _context;

    public AlignmentService(DataContext context)
    {
        _context = context;
    }

    public async Task<List<AlignmentDTO>> RetrieveAllAlignments()
    {
        var alignments = await _context.Alignments.AsNoTracking().ToListAsync();
        var orderedAlignments = alignments.OrderBy(a => a.Order);
        return orderedAlignments.Select(a => new AlignmentDTO
        {
            Alignment = a.Name
        }).ToList();
    }
}