using System;
using System.Data;
using System.Data.Common;
using System.Linq;

using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Repositories.Utilities;

namespace RegistrationAutoAssignment.Repositories
{
    public class SchoolChoiceRepository : ISchoolChoicesRepository
    {
        private bool _disposedValue;

        private DbConnection CntxDbConnect { get; set; }



        /// <summary>
        /// This constructor is being used by the Test framework.
        /// </summary>
        public SchoolChoiceRepository()
        { }

        /// <summary>
        /// This constructor is being used by the Test framework.
        /// Passing DbConnection to create repository.
        /// </summary>
        /// <param name="cntxDbConnect"></param>
        public SchoolChoiceRepository(DbConnection cntxDbConnect)
        {
            CntxDbConnect = cntxDbConnect;
        }

        /// <summary>
        /// Gets the student school choices for a student information passed in.
        /// </summary>
        /// <param name="stdRequest"></param>
        /// <returns></returns>
        public string GetNewSchoolChoicesForStudent(StudentSchoolParameters stdRequest)
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
            return returnedXml;

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
