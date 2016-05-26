using System;
using System.Data;
using System.Data.Common;
using System.Linq;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Repositories.Utilities;

namespace RegistrationAutoAssignment.Repositories
{
    public class SchoolChoiceRepository : ISchoolChoicesRepository
    {
        private bool _disposedValue;
        public DbConnection CntxDbConnect { get; }

        /// <summary>
        /// Creates entity context internally.
        /// </summary>
        public SchoolChoiceRepository()
        { AspenDbContext = new ExtractAspenEntities(); }

       
        public SchoolChoiceRepository(ExtractAspenEntities context)
        {
            AspenDbContext = context;
        }
        /// <summary>
        /// Passing DbConnection to create context.
        /// </summary>
        /// <param name="cntxDbConnect"></param>
        public SchoolChoiceRepository(DbConnection cntxDbConnect)
        {
            CntxDbConnect = cntxDbConnect;
            AspenDbContext = new ExtractAspenEntities(cntxDbConnect);
        }

        public ExtractAspenEntities AspenDbContext { get; set; }

        public string GetNewSchoolChoicesForStudent(StudentSchoolChoicesParameters stdRequest)
        {
          var client = new StudentSchoolChoices.ServiceClient();

            var returnedXml = client.GetNewSchoolChoicesForStudent(stdRequest.SchoolYear,
                stdRequest.Type, stdRequest.StudentNo, stdRequest.CaseId,
                stdRequest.AddressId, stdRequest.GeoParam, stdRequest.GradeParam,
                stdRequest.DoBparam, stdRequest.ProgramCodeList,
                stdRequest.IsAwcParam, stdRequest.IsBasParam, stdRequest.SnCodeParam,
                stdRequest.LepStatusParam,
                stdRequest.EldLevelParam, stdRequest.SifeStatusParam,
                stdRequest.FirstLangParam, stdRequest.SiblingsList,
                stdRequest.TierVersion);

            var ds = Serializer.ConvertXmlToDataSet(returnedXml);
            var myData = ds.Tables[0].AsEnumerable().ToList();

            var capacityRepository = new SchoolCapacityRepository(AspenDbContext);
            var schoolCapacityList = capacityRepository.GetSchoolCapacity(myData);


            var table = Serializer.ToDataTable(schoolCapacityList);
            ds.Tables.Add(table);
            return ds.GetXml();
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
