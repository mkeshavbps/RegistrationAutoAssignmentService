﻿using System;
using System.Collections.Generic;
using System.Data;
using RegistrationAutoAssignment.Entities;

namespace RegistrationAutoAssignment.Repositories.Interfaces
{
    public interface ISchoolCapacityRepository : IRepository, IDisposable
    {
        /// <summary>
        /// use the rows to create school capacity based on schYear,grade,program code and school Id
        /// </summary>
        /// <param name="dataRows"></param>
        /// <returns></returns>
        List<SCHOOL_CAPACITY> GetSchoolCapacity(List<DataRow> dataRows);
    }

   
}
