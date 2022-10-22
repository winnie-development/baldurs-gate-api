using BaldursGateAPI.Dtos.Race;

namespace BaldursGateAPI.Services.Race;

public interface IRaceService
{
    Task<List<RaceDTO>> RetrieveAllRaces();

}