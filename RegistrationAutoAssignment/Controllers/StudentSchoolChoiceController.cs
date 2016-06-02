using System;
using System.Web.Http;
using System.Web.Http.Description;
using RegistrationAutoAssignment.Attributes.Exceptions;
using RegistrationAutoAssignment.Services.Interfaces.Services;
using RegistrationAutoAssignment.Units.Interfaces;
using RegistrationAutoAssignment.Services.ServiceRequests;


namespace RegistrationAutoAssignment.Controllers
{
    [BpsException]
    public class StudentSchoolChoiceController : ApiController
    {
        private IStudentSchoolChoicesService StudentSchoolChoicesService { get; }

        public StudentSchoolChoiceController(IStudentSchoolChoicesService service)
        {
            StudentSchoolChoicesService = service;
        }

        #region " Contructor to work with unit of work.

        internal IUnitOfWork StudentUnitOfWork { get; }

        /// <summary>
        /// This constructor's need will be injected by Unity IOC container to provide constructor injection.  
        /// </summary>
        /// <param name="unitOfWork"></param>
        public StudentSchoolChoiceController(IUnitOfWork unitOfWork)
        {
            StudentUnitOfWork = unitOfWork;
        }
        #endregion

        /// <summary>
        /// Get the school Choices for new student
        /// </summary>
        /// <returns></returns>
        [Obsolete]
        [ResponseType(typeof(string))]
        public IHttpActionResult GetSchoolChoicesForNewStudent()
        {
            var  request = new StudentSchoolChoicesRequest
            {
                AddressId = "326371",
                CaseId = "635359",
                DoBparam = "2007-09-13 00:00:00.000",
                EldLevelParam = "1",
                FirstLangParam = "S",
                GeoParam = "326",
                GradeParam = "03",
                IsAwcParam = string.Empty,
                IsBasParam = string.Empty,
                LepStatusParam = "L",
                ProgramCodeList = string.Empty,
                SchoolYear = "2016-2017",
                SiblingsList = string.Empty,
                SifeStatusParam = string.Empty,
                SnCodeParam = string.Empty,
                StudentNo = "379111",
                TierVersion = "V2",
                Type = "Testing"
            };

            if (StudentSchoolChoicesService == null)
                return NotFound();

            var returnString = StudentSchoolChoicesService.InvokeService(request);

            return Ok(returnString);
        }

        /// <summary>
        /// Gets the student school choices and Waitlist information for a student.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IHttpActionResult GetStudentSchoolChoiceAndWaitList(StudentSchoolChoicesAndWaitListRequest request)
        {
            if (StudentSchoolChoicesService == null)
                return NotFound();

            var returnString = StudentSchoolChoicesService.GetStudentSchoolChoicesAndWaitList(request);

            return Ok(returnString);
        }
    }
}
