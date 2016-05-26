using System;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Interfaces;

namespace RegistrationAutoAssignment.Units.Interfaces
{
    /// <summary>
    /// A unit of work for transactional tasks.
    /// Add any transactional commits/rollbacks methods.
    /// </summary>
    public interface IUnitOfWork: IDisposable
    {
        int Save();

        ExtractAspenEntities Context { get; }
        IRepository Repository { get; set; }
    }
}
