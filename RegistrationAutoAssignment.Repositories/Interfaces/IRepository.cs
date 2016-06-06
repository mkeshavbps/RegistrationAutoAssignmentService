using System;
using RegistrationAutoAssignment.Entities.ExtractAspen;

namespace RegistrationAutoAssignment.Repositories.Interfaces
{
    /// <summary>
    /// Add any basic operations for the repository that are common to any repositories. 
    /// </summary>
    public interface IRepository: IDisposable
    {
        ExtractAspenEntities AspenDbContext { get; }
    }
}
