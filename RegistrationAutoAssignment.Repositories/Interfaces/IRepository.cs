using System;
using RegistrationAutoAssignment.Entities.BPSInterface;

namespace RegistrationAutoAssignment.Repositories.Interfaces
{
    /// <summary>
    /// Add any basic operations for the repository that are common to any repositories. 
    /// </summary>
    public interface IRepository : IDisposable
    {
        BPSInterfaceEntities BpsInterfaceContext { get; }
    }
}
