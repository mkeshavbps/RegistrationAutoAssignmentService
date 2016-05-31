namespace RegistrationAutoAssignment.Services.Interfaces.Requests
{
    public interface IStudentSchoolChoicesRequest :IRequest
    {
        string AddressId { get; set; }
        string CaseId { get; set; }
        string DoBparam { get; set; }
        string EldLevelParam { get; set; }
        string FirstLangParam { get; set; }
        string GeoParam { get; set; }
        string GradeParam { get; set; }
        string IsAwcParam { get; set; }
        string IsBasParam { get; set; }
        string LepStatusParam { get; set; }
        string ProgramCodeList { get; set; }
        string SchoolYear { get; set; }
        string SiblingsList { get; set; }
        string SifeStatusParam { get; set; }
        string SnCodeParam { get; set; }
        string StudentNo { get; set; }
        string TierVersion { get; set; }
        string Type { get; set; }
    }
}