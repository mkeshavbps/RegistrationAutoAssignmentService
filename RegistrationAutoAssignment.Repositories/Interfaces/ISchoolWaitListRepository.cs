namespace RegistrationAutoAssignment.Repositories.Interfaces
{
    public interface ISchoolWaitListRepository : IRepository
    {
        /// <summary>
        /// Get the student school wait lists for a specific student info passed.
        /// </summary>
        /// <param name="stdRequest"></param>
        /// <returns></returns>
        string GetStudentSchoolWaitList(StudentSchoolParameters stdRequest);
    }
}