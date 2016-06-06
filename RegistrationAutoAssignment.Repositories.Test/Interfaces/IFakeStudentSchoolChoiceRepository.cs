using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Interfaces;

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
