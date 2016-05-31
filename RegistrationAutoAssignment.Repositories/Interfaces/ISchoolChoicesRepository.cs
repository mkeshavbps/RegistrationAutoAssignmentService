namespace RegistrationAutoAssignment.Repositories.Interfaces
{
    public interface ISchoolChoicesRepository:IRepository
    {
        /// <summary>
        /// Gets the student school choices for a student information passed in.
        /// </summary>
        /// <param name="stdRequest"></param>
        /// <returns></returns>
        string GetNewSchoolChoicesForStudent(StudentSchoolParameters stdRequest);
    }
}