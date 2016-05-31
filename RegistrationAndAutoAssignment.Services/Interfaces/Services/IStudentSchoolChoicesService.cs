using RegistrationAutoAssignment.Services.Interfaces.Requests;

namespace RegistrationAutoAssignment.Services.Interfaces.Services
{
    public interface IStudentSchoolChoicesService : IServiceLayer
    {
        /// <summary>
        /// Gets the student school choices and wait list information.
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        string GetStudentSchoolChoicesAndWaitList(IStudentSchoolChoicesAndWaitListRequest request);
    }
}
