namespace RegistrationAutoAssignment.Repositories.Interfaces
{
    public interface ISchoolChoicesRepository:IRepository
    {
        string GetNewSchoolChoicesForStudent(StudentSchoolChoicesParameters stdRequest);
    }
}