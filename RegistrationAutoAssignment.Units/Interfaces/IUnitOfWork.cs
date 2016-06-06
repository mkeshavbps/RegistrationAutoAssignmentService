using System;
using System.Data.Entity;

namespace RegistrationAutoAssignment.Units.Interfaces
{
    /// <summary>
    /// A unit of work for transactional tasks.
    /// Add any transactional commits/rollbacks methods.
    /// </summary>
    public interface IUnitOfWork: IDisposable
    {
        int Save();

        
        DbContext CreatedContext { get; set; }

    }
}
