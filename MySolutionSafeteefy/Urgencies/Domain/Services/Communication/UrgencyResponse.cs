using MySolutionSafeteefy.Shared.Domain.Services.Communication;
using MySolutionSafeteefy.Urgencies.Domain.Models;

namespace MySolutionSafeteefy.Urgencies.Domain.Services.Communication;

public class UrgencyResponse : BaseResponse<Urgency>//Implement missing members all
{
    public UrgencyResponse(string message) : base(message)
    {
    }

    public UrgencyResponse(Urgency resource) : base(resource)
    {
    }
}