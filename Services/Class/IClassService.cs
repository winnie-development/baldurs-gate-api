using BaldursGateAPI.Dtos.Class;

namespace BaldursGateAPI.Services.Class;

public interface IClassService
{
    Task<List<ClassDTO>> RetrieveAllClasses();
}