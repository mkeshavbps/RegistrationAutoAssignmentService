using System;
using System.Data.Common;
using System.Linq;
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
        public string GetStudentSchoolWaitList(StudentSchoolParameters stdRequest)
        {
            var waitListByStudentSchool = (from waitList in AspenDbContext.STUDENT_WAIT_LIST
                join std in AspenDbContext.STUDENTs on waitList.SWL_STD_OID equals std.STD_OID
                join capacity in AspenDbContext.SCHOOL_CAPACITY on waitList.SWL_SCA_OID equals capacity.SCA_OID
                join context in AspenDbContext.DISTRICT_SCHOOL_YEAR_CONTEXT on capacity.SCA_CTX_OID equals
                    context.CTX_OID
                join school in AspenDbContext.SCHOOLs on capacity.SCA_SKL_OID equals school.SKL_OID
                where stdRequest.SchoolYear != null && (waitList.SWL_ACTION_CODE == null && context.CTX_SCHOOL_YEAR == decimal.Parse(stdRequest.SchoolYear))
                orderby std.STD_ID_LOCAL, waitList.SWL_RANK
                select
                    new
                    {
                        StudentLocalId = std.STD_ID_LOCAL,
                        ProgramCode = capacity.SCA_PROGRAM_CODE,
                        GradeLevel = capacity.SCA_GRADE_LEVEL,
                        SchoolId = school.SKL_SCHOOL_ID,
                        Rank = waitList.SWL_RANK
                    }).ToList();
            return null;
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
