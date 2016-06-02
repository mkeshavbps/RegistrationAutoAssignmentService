using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Units.UnitOfWork
{
    public class DbContextFactory : IDbContextFactory
    {
        public ExtractAspenEntities Context { get; }

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