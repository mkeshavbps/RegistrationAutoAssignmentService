using System.Collections.Generic;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Interfaces;

namespace RegistrationAutoAssignment.Repositories.Tests.Interfaces
{
    /// <summary>
    /// Created a fake repository.
    /// </summary>
    public interface IFakeStudentSchoolChoiceRepository : ISchoolChoicesRepository
    {

        void AddStudent(STUDENT student);
        IEnumerable<STUDENT> GetAllStudents { get; set; }
    }
}
