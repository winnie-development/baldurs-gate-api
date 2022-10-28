using BaldursGateAPI.Dtos.Alignment;

namespace BaldursGateAPI.Services.Alignment;

public interface IAlignmentService
{
    Task<List<AlignmentDto>> RetrieveAllAlignments();
}