using System;
using System.Data.Common;

using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;

using RegistrationAutoAssignment.Entities.ExtractAspen;

namespace RegistrationAutoAssignment.Units.UnitOfWork
{
    /// <summary>
    /// Student Choice unit of work.
    /// </summary>
    public class StudentSchoolChoicesUnitOfWork : IStudentSchoolChoicesUnitOfWork
    {
        private bool _disposed;

        #region "Get DbContext, repositories when needed"

        /// <summary>
        /// Aspen extracted entities.
        /// </summary>
        private ExtractAspenEntities Context { get; }

        private IRepository Repository { get; set; }

        public DbConnection CntxDbConnect { get; }

        IRepository IUnitOfWork.Repository { get; set; }

        #endregion

        /// <summary>
        /// Creates an instance of the unit of work along with concrete context and repository implementations.
        /// Used by the test framework.
        /// </summary>
        /// <summary>
        /// Creates an instance using the DbConnection.
        /// </summary>
        /// <param name="cntxDbConnect"></param>
        /// <param name="schoolChoicesRepository"></param>
        public StudentSchoolChoicesUnitOfWork(DbConnection cntxDbConnect, ISchoolChoicesRepository schoolChoicesRepository)
        {
            CntxDbConnect = cntxDbConnect;
        }

        /// <summary>
        /// Creates an instance using the factory to get the instance of the context and repositories
        /// </summary>
        /// <param name="factory"></param>
        public StudentSchoolChoicesUnitOfWork(IDbContextFactory factory)
        {
            Context = factory.GetContext();
        }


        #region "IDisposable pattern"
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            Context.SaveChanges();
        }

        private void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    Context?.Dispose();

            _disposed = true;
        }

        #endregion





        /// <summary>
        /// Persist the changes to the context and the database.
        /// </summary>
        /// <returns></returns>
        int IUnitOfWork.Save()
        {
            var returnedInt = Context.SaveChanges();
            return returnedInt;
        }
    }
}
