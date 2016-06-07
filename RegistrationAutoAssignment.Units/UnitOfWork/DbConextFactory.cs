using RegistrationAutoAssignment.Entities.BPSInterface;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Units.UnitOfWork
{
    public class DbContextFactory : IDbContextFactory
    {
        private BPSInterfaceEntities Context { get; }

        public DbContextFactory()
        {
            Context = new BPSInterfaceEntities();
        }

        public BPSInterfaceEntities GetContext()
        {
            return Context;
        }
    }
}