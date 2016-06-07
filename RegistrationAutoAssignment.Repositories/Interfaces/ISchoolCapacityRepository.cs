using System.Collections.Generic;
using System.Data;

namespace RegistrationAutoAssignment.Repositories.Interfaces
{
    public interface ISchoolCapacityRepository
    {
        /// <summary>
        /// use the rows to create school capacity based on schYear,grade,program code and school Id
        /// </summary>
        /// <param name="dataRows"></param>
        /// <returns></returns>
        List<SchoolCapacity> GetSchoolCapacity(List<DataRow> dataRows);
    }
}
