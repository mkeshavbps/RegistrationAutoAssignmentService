using System.Collections.Generic;
using RegistrationAutoAssignment.Entities;
using RegistrationAutoAssignment.Repositories.Interfaces;

namespace RegistrationAutoAssignment.Repositories.Tests.Interfaces
{
    /// <summary>
    /// Created a fake repository.
    /// </summary>
    public interface IFakeStudentSchoolChoiceRepository : IRepository
    {

        void AddStudent(STUDENT student);
        IEnumerable<STUDENT> GetAllStudents { get; set; }

        string GetNewSchoolChoicesForStudent(StudentSchoolChoicesParameters studentChoicesParameters);
    }
}
