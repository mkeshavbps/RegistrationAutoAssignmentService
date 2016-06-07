using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;

namespace RegistrationAutoAssignment.Repositories
{
    public class SchoolCapacityRepository : GenericRepository<SchoolCapacity>, ISchoolCapacityRepository, IDisposable
    {
        private bool _disposedValue;

        /// <summary>
        /// Use this constructor to inject the context directly to create repository.
        /// </summary>
        /// <param name="context"></param>
        public SchoolCapacityRepository(DbContext context) : base(context)
        { }

        /// <summary>
        /// Use this constructor to set the context for the repository
        /// Also, the repository knows the parent unit of work.
        /// </summary>
        /// <param name="unitOfWork"></param>
        public SchoolCapacityRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        { }


        /// <summary>
        /// Gets teh school Capacity
        /// </summary>
        /// <param name="dataRows"></param>
        /// <returns></returns>
        public List<SchoolCapacity> GetSchoolCapacity(List<DataRow> dataRows)
        {
            var list = new List<SchoolCapacity>();
            dataRows.ForEach(item => GetSchoolCapacityByGradePrgCodeAndSchYear(item, list));
            return list;
        }

        private void GetSchoolCapacityByGradePrgCodeAndSchYear(DataRow obj, List<SchoolCapacity> list)
        {
            throw new NotImplementedException("This method has not functionality");

            //decimal schoolYear = 0;
            //var schYear = obj.Field<string>("SchoolYear");
            //if (!string.IsNullOrWhiteSpace(schYear))
            //    decimal.TryParse(schYear.Split(Convert.ToChar("-")).Last(), out schoolYear);

            //var grade = obj.Field<string>("Grade");
            //var programCode = obj.Field<string>("ProgramCode");
            //var schoolId = obj.Field<string>("Sch");

            //var query = from schoolCapacity in DbContext.SCHOOL_CAPACITY
            //                join sch in DbContext.SCHOOLs on schoolCapacity.SCA_SKL_OID equals sch.SKL_OID
            //                join disCtx in DbContext.DISTRICT_SCHOOL_YEAR_CONTEXT on schoolCapacity.SCA_CTX_OID equals
            //                    disCtx.CTX_OID
            //                where schoolCapacity.SCA_GRADE_LEVEL == grade && schoolCapacity.SCA_PROGRAM_CODE == programCode
            //                      && sch.SKL_SCHOOL_ID == schoolId && disCtx.CTX_SCHOOL_YEAR == schoolYear
            //                select schoolCapacity;

            //list?.AddRange(query.AsEnumerable());
        }


        #region IDisposable Support

        private void Dispose(bool disposing)
        {
            if (_disposedValue) return;
            if (disposing)
            {
                Dispose();
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
    /// A dummy class created to make sure no errors within the solution.
    /// This class do not have any functionality.
    /// </summary>
    public class SchoolCapacity
    { }
}
