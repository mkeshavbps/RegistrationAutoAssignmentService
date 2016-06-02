using System;
using System.Collections;
using RegistrationAutoAssignment.Repositories;
using RegistrationAutoAssignment.Units.Interfaces;
using RegistrationAutoAssignment.Repositories.Interfaces;
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

        /// <summary>
        /// Access all unit of works that the StudentChoicesService service uses to access.
        /// </summary>
        private Hashtable AllUnitOfWorks { get; set; } = new Hashtable();


        /// <summary>
        /// Access all repositories that the StudentChoicesService service uses to access.
        /// </summary>
        private Hashtable AllRepositories { get; set; } = new Hashtable();

        /// <summary>
        /// Specific unit of work 
        /// </summary>
        private IUnitOfWork UnitOfWork { get; }

        /// <summary>
        /// Specific repository
        /// </summary>
        private IRepository Repository { get; }

        /// <summary>
        /// Service constructor with unit of work.
        /// </summary>
        /// <param name="unitOfWork"></param>
        public StudentSchoolChoicesService(IUnitOfWork unitOfWork )
        {
            UnitOfWork = unitOfWork;
            UnitOfWork.Repository = unitOfWork.Repository;

            AllUnitOfWorks?.Add(unitOfWork.GetType(), unitOfWork);
            AllRepositories?.Add(UnitOfWork.Repository.GetType(), UnitOfWork.Repository);

            //AddUnitOfWork(unitOfWork.GetType());
            //AddRepository(schoolChoicesRepository.GetType());

            //AddUnitOfWork(typeof(IStudentSchoolChoicesUnitOfWork));
            //AddRepository(typeof(ISchoolChoicesRepository));

            //AddUnitOfWork(typeof(StudentSchoolChoicesUnitOfWork));
            //AddRepository(typeof(SchoolChoiceRepository));
        }


        /// <summary>
        /// Service constructor with repository.
        /// </summary>
        /// <param name="repository"></param>
        public StudentSchoolChoicesService(IRepository repository)
        {
            AllRepositories?.Add(repository.GetType(), repository);
            Repository = repository;
        }

        #region "IDisposable pattern"
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    Dispose();

            _disposed = true;
        }

        #endregion

        /// <summary>
        /// Adds the other unit of works to the read only collection.
        /// </summary>
        /// <returns></returns>
        public IUnitOfWork AddUnitOfWork(Type typeOfWork) 
        {
            if (AllUnitOfWorks == null)
                AllUnitOfWorks = new Hashtable();

            var type = typeOfWork.Name;
            if (AllUnitOfWorks.ContainsKey(type)) return (IUnitOfWork)AllUnitOfWorks[type];
            var uowInstance =
                Activator.CreateInstance(typeOfWork);

            AllUnitOfWorks.Add(type, uowInstance);
            return (IUnitOfWork)AllUnitOfWorks[type];
        }

        /// <summary>
        /// Adds the repositories to the read only collection.
        /// </summary>
        /// <returns></returns>
        public IRepository AddRepository(Type typeOfRepository)
        {
            if (AllRepositories == null)
                AllRepositories = new Hashtable();

            var type = typeOfRepository.Name;
            if (AllRepositories.ContainsKey(type)) return (IRepository)AllRepositories[type];

            var uowInstance =
                Activator.CreateInstance(typeOfRepository);
            AllRepositories.Add(type, uowInstance);

            return (IRepository)AllRepositories[type];
        }

        /// <summary>
        /// Gateway to invoke the service request through any controllers.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string InvokeService(IRequest request)
        {
            var studentSchoolChoicesRequest = request as IStudentSchoolChoicesRequest;
            var repository = UnitOfWork.Repository as ISchoolChoicesRepository;
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
            return repository?.GetNewSchoolChoicesForStudent(parameters);
        }


        /// <summary>
        /// Gets the student school choices and wait list information for a student.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public string GetStudentSchoolChoicesAndWaitList(IStudentSchoolChoicesAndWaitListRequest request)
        {
            var repository = Repository as ISchoolWaitListRepository;
            var parameters = new StudentSchoolParameters
            {
                SchoolYear = request?.SchoolYear,
                StudentNo = request?.StudentNo
            };

            var waitListNumbers = repository?.GetStudentSchoolWaitList(parameters);
            return waitListNumbers;
        }

    }
}

