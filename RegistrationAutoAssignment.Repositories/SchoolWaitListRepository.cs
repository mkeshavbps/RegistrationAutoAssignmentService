using System;
using System.Data.Entity;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Repositories
{
    public class SchoolWaitListRepository : GenericRepository<StudentWaitList>, ISchoolWaitListRepository
    {
        private bool _disposedValue;

        /// <summary>
        /// Create the repository using the context injected.
        /// </summary>
        /// <param name="context"></param>
        public SchoolWaitListRepository(DbContext context) : base(context)
        { }

        /// <summary>
        /// Use this constructor to set the context for the repository
        /// Also, the repository knows the parent unit of work.
        /// </summary>
        /// <param name="unitOfWork"></param>
        public SchoolWaitListRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }


        /// <summary>
        /// Gets the student school waitlist for a specific student info.
        /// </summary>
        /// <param name="stdRequest"></param>
        /// <returns></returns>
        public string GetStudentSchoolWaitList(StudentSchoolParameters stdRequest)
        {
            throw new NotImplementedException("This method does not have any functionality");

            //if (stdRequest == null) throw new ArgumentNullException(nameof(stdRequest));

            //var schYear = decimal.Parse(stdRequest.SchoolYear);
            //var waitListByStudentSchool = (from waitList in DbContext.STUDENT_WAIT_LIST
            //    join std in DbContext.STUDENTs on waitList.SWL_STD_OID equals std.STD_OID
            //    join capacity in DbContext.SCHOOL_CAPACITY on waitList.SWL_SCA_OID equals capacity.SCA_OID
            //    join context in DbContext.DISTRICT_SCHOOL_YEAR_CONTEXT on capacity.SCA_CTX_OID equals
            //        context.CTX_OID
            //    join school in DbContext.SCHOOLs on capacity.SCA_SKL_OID equals school.SKL_OID
            //    where waitList.SWL_ACTION_CODE == null && context.CTX_SCHOOL_YEAR == schYear && std.STD_ID_LOCAL == stdRequest.StudentNo
            //    orderby std.STD_ID_LOCAL, waitList.SWL_RANK
            //    select
            //        new
            //        {
            //            StudentLocalId = std.STD_ID_LOCAL,
            //            ProgramCode = capacity.SCA_PROGRAM_CODE,
            //            GradeLevel = capacity.SCA_GRADE_LEVEL,
            //            SchoolId = school.SKL_SCHOOL_ID,
            //            Rank = waitList.SWL_RANK
            //        }).ToList();

            //var returnedString = waitListByStudentSchool.ToDataSet().GetXml();
            //return returnedString;

        }

        #region IDisposable Support

        private void Dispose(bool disposing)
        {
            if (_disposedValue) return;
            if (disposing)
            {
                DbContext.Dispose();
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

    /// <summary>
    /// A dummy class to make sure there are no errors in the solution.
    /// This class do not provide any functionality.
    /// </summary>
    public class StudentWaitList
    {
    }
}
