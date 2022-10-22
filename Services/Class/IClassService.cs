using BaldursGateAPI.Dtos.Class;

namespace BaldursGateAPI.Services.Classes;

public interface IClassService
{
    Task<List<ClassDTO>> RetrieveAllClasses();
}