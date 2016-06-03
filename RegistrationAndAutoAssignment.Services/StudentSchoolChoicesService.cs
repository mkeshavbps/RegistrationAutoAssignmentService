using System;
using RegistrationAutoAssignment.Repositories;
using RegistrationAutoAssignment.Units.Interfaces;
using RegistrationAutoAssignment.Services.Interfaces.Requests;
using RegistrationAutoAssignment.Services.Interfaces.Services;

namespace RegistrationAutoAssignment.Services
{
    /// <summary>
    /// This service container has a unit of work/s composed with one or more repositiories.
    /// </summary>
    public class StudentSchoolChoicesService : IStudentSchoolChoicesService
    {
        private bool _disposed;

        private SchoolChoiceRepository SchoolChoicesRepository { get; }
        private SchoolCapacityRepository CapacityRepository { get; }
        private SchoolWaitListRepository WaitListRepository { get; }
        private IStudentSchoolChoicesUnitOfWork UnitOfWork { get; }


        /// <summary>
        /// Service constructor with unit of work.
        /// </summary>
        /// <param name="unitOfWork"></param>
        /// <param name="schoolChoicesRepository"></param>
        /// <param name="schoolCapacityRepository"></param>
        /// <param name="schoolWaitListRepository"></param>
        public StudentSchoolChoicesService(IStudentSchoolChoicesUnitOfWork unitOfWork, SchoolChoiceRepository schoolChoicesRepository, SchoolCapacityRepository schoolCapacityRepository, SchoolWaitListRepository schoolWaitListRepository)
        {
            UnitOfWork = unitOfWork;
            SchoolChoicesRepository = schoolChoicesRepository;
            CapacityRepository = schoolCapacityRepository;
            WaitListRepository = schoolWaitListRepository;
        }


        #region "IDisposable pattern"
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        private void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    Dispose();

            _disposed = true;
        }

        #endregion

      

        /// <summary>
        /// Gateway to invoke the service request through any controllers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string InvokeService(IRequest request)
        {
            var studentSchoolChoicesRequest = request as IStudentSchoolChoicesRequest;
          
            var parameters = new StudentSchoolParameters()
            {
                AddressId = studentSchoolChoicesRequest?.AddressId,
                CaseId = studentSchoolChoicesRequest?.CaseId,
                DoBparam = studentSchoolChoicesRequest?.DoBparam,
                EldLevelParam = studentSchoolChoicesRequest ?.EldLevelParam,
                FirstLangParam = studentSchoolChoicesRequest ?.FirstLangParam,
                GeoParam = studentSchoolChoicesRequest ?.GeoParam,
                GradeParam = studentSchoolChoicesRequest ?.GradeParam,
                IsAwcParam = studentSchoolChoicesRequest ?.IsAwcParam,
                IsBasParam = studentSchoolChoicesRequest ?.IsBasParam,
                LepStatusParam = studentSchoolChoicesRequest ?.LepStatusParam,
                ProgramCodeList = studentSchoolChoicesRequest ?.ProgramCodeList,
                SchoolYear = studentSchoolChoicesRequest ?.SchoolYear,
                SiblingsList = studentSchoolChoicesRequest ?.SiblingsList,
                SifeStatusParam = studentSchoolChoicesRequest ?.SifeStatusParam,
                SnCodeParam = studentSchoolChoicesRequest ?.SnCodeParam,
                StudentNo = studentSchoolChoicesRequest ?.StudentNo,
                TierVersion = studentSchoolChoicesRequest ?.TierVersion,
                Type = studentSchoolChoicesRequest ?.Type
            };
            return SchoolChoicesRepository?.GetNewSchoolChoicesForStudent(parameters);
        }


        /// <summary>
        /// Gets the student school choices and wait list information for a student.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetStudentSchoolChoicesAndWaitList(IStudentSchoolChoicesAndWaitListRequest request)
        {
            var parameters = new StudentSchoolParameters
            {
                SchoolYear = request?.SchoolYear,
                StudentNo = request?.StudentNo
            };

            var waitListNumbers = WaitListRepository?.GetStudentSchoolWaitList(parameters);
            return waitListNumbers;
        }

    }
}

