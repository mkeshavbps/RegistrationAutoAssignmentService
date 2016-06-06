using System.Collections.Generic;
using System.Data;
using RegistrationAutoAssignment.Entities.ExtractAspen;

namespace RegistrationAutoAssignment.Repositories.Interfaces
{
    public interface ISchoolCapacityRepository
    {
        /// <summary>
        /// use the rows to create school capacity based on schYear,grade,program code and school Id
        /// </summary>
        /// <param name="dataRows"></param>
        /// <returns></returns>
        List<SCHOOL_CAPACITY> GetSchoolCapacity(List<DataRow> dataRows);
    }

   
}
