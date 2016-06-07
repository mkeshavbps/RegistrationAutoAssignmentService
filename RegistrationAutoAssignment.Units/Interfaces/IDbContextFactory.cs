using RegistrationAutoAssignment.Entities.BPSInterface;

namespace RegistrationAutoAssignment.Units.Interfaces
{
    public interface IDbContextFactory
    {
        BPSInterfaceEntities GetContext();
    }
}