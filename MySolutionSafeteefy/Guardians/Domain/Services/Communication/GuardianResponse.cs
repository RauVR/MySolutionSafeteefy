using MySolutionSafeteefy.Guardians.Domain.Models;
using MySolutionSafeteefy.Shared.Domain.Services.Communication;

namespace MySolutionSafeteefy.Guardians.Domain.Services.Communication;

public class GuardianResponse: BaseResponse<Guardian>  //Implement missing members all
{
    public GuardianResponse(string message) : base(message)
    {
    }

    public GuardianResponse(Guardian resource) : base(resource)
    {
    }
}

//Luego vamos a Guardians.Domain.Services y creamos el IGuardianService , lo
//mismo hacemos para los otros bounded