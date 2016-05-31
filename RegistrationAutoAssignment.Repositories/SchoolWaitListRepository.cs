using System;
using System.Data.Common;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Interfaces;

namespace RegistrationAutoAssignment.Repositories
{
    public class SchoolWaitListRepository : ISchoolWaitListRepository
    {
        private bool _disposedValue;
        public DbConnection CntxDbConnect { get; }

        /// <summary>
        /// Creates entity context internally.
        /// </summary>
        public SchoolWaitListRepository()
        { AspenDbContext = new ExtractAspenEntities(); }


        public SchoolWaitListRepository(ExtractAspenEntities context)
        {
            AspenDbContext = context;
        }
        /// <summary>
        /// Passing DbConnection to create context.
        /// </summary>
        /// <param name="cntxDbConnect"></param>
        public SchoolWaitListRepository(DbConnection cntxDbConnect)
        {
            CntxDbConnect = cntxDbConnect;
            AspenDbContext = new ExtractAspenEntities(cntxDbConnect);
        }

        public ExtractAspenEntities AspenDbContext { get; set; }

        /// <summary>
        /// Gets the student school waitlist for a specific student info.
        /// </summary>
        /// <param name="stdRequest"></param>
        /// <returns></returns>
        public int GetStudentSchoolWaitList(StudentSchoolParameters stdRequest)
        {
            throw new NotImplementedException();
        }

        #region IDisposable Support

        protected virtual void Dispose(bool disposing)
        {
            if (_disposedValue) return;
            if (disposing)
            {
                AspenDbContext.Dispose();
            }
            _disposedValue = true;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
      
        #endregion
    }
}
