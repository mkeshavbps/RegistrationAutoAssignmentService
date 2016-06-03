using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Units.UnitOfWork
{
    public class DbContextFactory : IDbContextFactory
    {
        private ExtractAspenEntities Context { get; }

        public DbContextFactory()
        {
            Context = new ExtractAspenEntities();
        }

        public ExtractAspenEntities GetContext()
        {
            return Context;
        }
    }
}