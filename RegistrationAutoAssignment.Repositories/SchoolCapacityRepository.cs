using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Interfaces;

namespace RegistrationAutoAssignment.Repositories
{
    public class SchoolCapacityRepository : GenericRepository<SCHOOL_CAPACITY>, ISchoolCapacityRepository, IDisposable
    {
        private bool _disposedValue;

        public SchoolCapacityRepository(ExtractAspenEntities context) : base(context)
        { }


        /// <summary>
        /// Gets teh school Capacity
        /// </summary>
        /// <param name="dataRows"></param>
        /// <returns></returns>
        public List<SCHOOL_CAPACITY> GetSchoolCapacity(List<DataRow> dataRows)
        {
            var list = new List<SCHOOL_CAPACITY>();
            dataRows.ForEach(item => GetSchoolCapacityByGradePrgCodeAndSchYear(item, list));
            return list;
        }

        private void GetSchoolCapacityByGradePrgCodeAndSchYear(DataRow obj, List<SCHOOL_CAPACITY> list)
        {
            decimal schoolYear = 0;
            var schYear = obj.Field<string>("SchoolYear");
            if (!string.IsNullOrWhiteSpace(schYear))
                decimal.TryParse(schYear.Split(Convert.ToChar("-")).Last(), out schoolYear);

            var grade = obj.Field<string>("Grade");
            var programCode = obj.Field<string>("ProgramCode");
            var schoolId = obj.Field<string>("Sch");

            var query = from schoolCapacity in DbContext.SCHOOL_CAPACITY
                            join sch in DbContext.SCHOOLs on schoolCapacity.SCA_SKL_OID equals sch.SKL_OID
                            join disCtx in DbContext.DISTRICT_SCHOOL_YEAR_CONTEXT on schoolCapacity.SCA_CTX_OID equals
                                disCtx.CTX_OID
                            where schoolCapacity.SCA_GRADE_LEVEL == grade && schoolCapacity.SCA_PROGRAM_CODE == programCode
                                  && sch.SKL_SCHOOL_ID == schoolId && disCtx.CTX_SCHOOL_YEAR == schoolYear
                            select schoolCapacity;

            list?.AddRange(query.AsEnumerable());
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
}
