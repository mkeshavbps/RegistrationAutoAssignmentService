using RegistrationAutoAssignment.Entities.ExtractAspen;

namespace RegistrationAutoAssignment.Units.Interfaces
{
    public interface IDbContextFactory
    {
        ExtractAspenEntities GetContext();
    }
}