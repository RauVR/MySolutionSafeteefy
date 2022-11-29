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