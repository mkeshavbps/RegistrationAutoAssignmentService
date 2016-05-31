using System;
using RegistrationAutoAssignment.Services.Interfaces.Requests;

namespace RegistrationAutoAssignment.Services.Interfaces
{

    /// <summary>
    /// Facade for all the existing/new implemenation of the services.
    /// </summary>
    public interface IRequestFacade : IDisposable
    {
        string InvokeService(IRequest studentChoicesRequest);
    }
  
}