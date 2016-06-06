using System;
using System.Data.Entity;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Units.UnitOfWork
{
    /// <summary>
    /// Student Choice unit of work.
    /// </summary>
    public class LogMessageUnitOfWork : ILogMessageUnitOfWork
    {
        private bool _disposed;

        public DbContext CreatedContext { get; set; }

        /// <summary>
        /// Creates an instance using the repository
        /// </summary>
        /// <param name="factory"></param>
        public LogMessageUnitOfWork(IDbContextFactory factory)
        {
            CreatedContext = factory.GetContext();
        }


        #region "IDisposable pattern"
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Save()
        {
            CreatedContext.SaveChanges();
        }

     

        private void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                {
                    CreatedContext?.Dispose();
                }

            _disposed = true;
        }

        #endregion

        /// <summary>
        /// Persist the changes to the context and the database.
        /// </summary>
        /// <returns></returns>
        int IUnitOfWork.Save()
        {
            var returnedInt = CreatedContext.SaveChanges();
            return returnedInt;
        }
    }
}
