using RegistrationAutoAssignment.Services.Interfaces.Requests;

namespace RegistrationAutoAssignment.Services.ServiceRequests
{
    public class StudentSchoolChoicesAndWaitListRequest : IStudentSchoolChoicesAndWaitListRequest
    {
        public string ClientCode { get; set; }

        public string SchoolYear { get; set; }

        public string StudentNo { get; set; }
    }
}