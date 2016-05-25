using RegistrationAutoAssignment.Services.Interfaces.Requests;

namespace RegistrationAutoAssignment.Services.ServiceRequests
{
    public class StudentChoicesRequest : IStudentChoicesRequest
{
        public string SchoolYear { get; set; }
        public string Type { get; set; }
        public string StudentNo { get; set; }
        public string CaseId { get; set; }
        public string AddressId { get; set; }
        public string GeoParam { get; set; }
        public string GradeParam { get; set; }
        public string DoBparam { get; set; }
        public string ProgramCodeList { get; set; }
        public string IsAwcParam { get; set; }
        public string IsBasParam { get; set; }
        public string SnCodeParam { get; set; }
        public string LepStatusParam { get; set; }
        public string EldLevelParam { get; set; }
        public string SifeStatusParam { get; set; }
        public string FirstLangParam { get; set; }
        public string SiblingsList { get; set; }
        public string TierVersion { get; set; }

        public string ClientCode { get; set; }
}
}
