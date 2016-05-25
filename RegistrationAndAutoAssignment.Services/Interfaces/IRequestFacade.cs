using RegistrationAutoAssignment.Services.Interfaces.Requests;

namespace RegistrationAutoAssignment.Services.Interfaces
{
    public interface IRequestFacade
    {
        string InvokeService(IRequest studentChoicesRequest);
    }
  
}