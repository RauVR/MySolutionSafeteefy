using MySolutionSafeteefy.Guardians.Domain.Models;
using MySolutionSafeteefy.Guardians.Domain.Services.Communication;

namespace MySolutionSafeteefy.Guardians.Domain.Services;

public interface IGuardianService
{
    Task<IEnumerable<Guardian>> ListAsync();
    Task<Guardian> FindByIdAsync(int id);
    Task<GuardianResponse> SaveAsync(Guardian guardian);
    Task<GuardianResponse> UpdateAsync(int id, Guardian guardian);
    Task<GuardianResponse> DeleteAsync(int id);
}

//Luego vamos a Guardians.Resources y creamos la clase GuardianResource