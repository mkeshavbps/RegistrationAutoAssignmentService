using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories.Tests.Interfaces;
using RegistrationAutoAssignment.Setup;


namespace RegistrationAutoAssignment.Repositories.Tests
{
    [TestClass]
    public class TestStudentSchoolChoiceRepository 
    {
        public InitializeEntityFramework Initialize { get; } = new InitializeEntityFramework();

        public List<STUDENT> Students { get; set; } = new List<STUDENT>();
        public Mock<IFakeStudentSchoolChoiceRepository> FakeStudentSchoolChoiceMock { get; private set; }


        #region "Implemented interface IFakeStudentSchoolChoiceRepository 

        public void AddStudent(STUDENT student)
        {
            FakeStudentSchoolChoiceMock.Object.AspenDbContext?.STUDENTs.Add(new STUDENT { STD_OID = "1234" });
        }

        public IEnumerable<STUDENT> GetAllStudents { get; set; }

        public ExtractAspenEntities AspenDbContext { get; set; }

        #endregion

        /// <summary>
        /// Mocking the repository pattern (Arrage/configure repository
        /// by creating a new student and adding the student
        /// </summary>
        /// <returns></returns>
        public Mock<IFakeStudentSchoolChoiceRepository> StudentScoolChoicesRepositoryFake()
        {
            FakeStudentSchoolChoiceMock = new Mock<IFakeStudentSchoolChoiceRepository>();
            FakeStudentSchoolChoiceMock.Setup(x => x.AddStudent(It.IsAny<STUDENT>()))
                .Callback((STUDENT s) =>
                    {
                        Students?.Add(s);
                    });
            FakeStudentSchoolChoiceMock.Setup(x => x.GetAllStudents).Returns(Students);
            return FakeStudentSchoolChoiceMock;

        }


        /// <summary>
        /// Gets all the students.
        /// </summary>
        [TestMethod]
        public void Test_StudentSchoolChoicesRepositoryFake()
        {
            var fakeRepository = StudentScoolChoicesRepositoryFake();
            fakeRepository.Object.AddStudent(new STUDENT {STD_OID = "2345"});
            Assert.IsNotNull(fakeRepository.Object.GetAllStudents);
        }

        /// <summary>
        /// Test to assert the fake repository instance creation.
        /// </summary>
        [TestMethod]
        public void Test_StudentSchoolRepositoryInstance()
        {
            FakeStudentSchoolChoiceMock = new Mock<IFakeStudentSchoolChoiceRepository>();
            Assert.IsNotNull(FakeStudentSchoolChoiceMock.Object);
        }

        /// <summary>
        /// Testing the web service call using Mock
        /// </summary>
        [TestMethod]
        public void Test_StudentSchoolChoicesWebService()
        {
            FakeStudentSchoolChoiceMock = new Mock<IFakeStudentSchoolChoiceRepository>();
            var paramMock = new Mock<StudentSchoolParameters>(MockBehavior.Loose);
            paramMock.Object.AddressId = "326371";
            paramMock.Object.CaseId = "635359";
            paramMock.Object.DoBparam = "2007-09-13 00:00:00.000";
            paramMock.Object.EldLevelParam = "1";
            paramMock.Object.FirstLangParam = "S";
            paramMock.Object.GeoParam = "326";
            paramMock.Object.GradeParam = "03";
            paramMock.Object.IsAwcParam = string.Empty;
            paramMock.Object.IsBasParam = string.Empty;
            paramMock.Object.LepStatusParam = "L";
            paramMock.Object.ProgramCodeList = string.Empty;
            paramMock.Object.SchoolYear = "2016-2017";
            paramMock.Object.SiblingsList = string.Empty;
            paramMock.Object.SifeStatusParam = string.Empty;
            paramMock.Object.SnCodeParam = string.Empty;
            paramMock.Object.StudentNo = "379111";
            paramMock.Object.TierVersion = "V2";
            paramMock.Object.Type = "Testing";

            FakeStudentSchoolChoiceMock.Setup(m => m.GetNewSchoolChoicesForStudent(paramMock.Object))
                .Returns("<NewDataSet><StudentId></StudentId><SchoolId></SchoolId></NewDataSet>");

            var returnedString = FakeStudentSchoolChoiceMock.Object?.GetNewSchoolChoicesForStudent(paramMock.Object);
            Assert.IsNotNull(returnedString);
        }
    }

   

}
