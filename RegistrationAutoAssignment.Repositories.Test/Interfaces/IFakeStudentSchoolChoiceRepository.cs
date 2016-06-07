using System.Collections.Generic;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Setup.ExtractAspen;

namespace RegistrationAutoAssignment.Repositories.Tests.Interfaces
{
    /// <summary>
    /// Created a fake repository.
    /// </summary>
    public interface IFakeStudentSchoolChoiceRepository : IGenericRepository<STUDENT>, ISchoolChoicesRepository
    {

        ExtractAspenEntities DbContext { get; set; }
        void AddStudent(STUDENT student);
        IEnumerable<STUDENT> GetAllStudents { get; set; }

    }
}
