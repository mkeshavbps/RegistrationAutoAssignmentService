namespace RegistrationAutoAssignment.Services.Interfaces.Requests
{
    public interface IStudentSchoolChoicesAndWaitListRequest : IRequest
    {
        string SchoolYear { get; set; }
        string StudentNo { get; set; }
      
    }
}