using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RegistrationAutoAssignment.Repositories;
using RegistrationAutoAssignment.Setup;

namespace RegistrationAutoAssignment.Units.Tests
{
    [TestClass]
    public class TestStudentChoicesUnitOfWork
    {

        public InitializeEntityFramework Initialize { get; } = new InitializeEntityFramework();

        /// <summary>
        /// Test to assert the fake Uow instance creation
        /// </summary>
        [TestMethod]
        public void Test_UnitOfWorkWithFakeRepositoryInstance()
        {
           var fakeStudentSchoolChoiceUoWMock = new Mock<IFakeUnitOfWork>();
            Assert.IsNotNull(fakeStudentSchoolChoiceUoWMock.Object);
        }

        [TestMethod]
        public void Test_UnitOfWorkWithFakeRepository_InvokingWebServiceCall()
        {

            using (Initialize.MockedUnitOfWork.Object.Repository as IFakeRepository)
            {
                var paramMock = new Mock<StudentSchoolChoicesParameters>(MockBehavior.Loose);
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

                var fakeRepository = new Mock<IFakeRepository>();
                fakeRepository.Setup(m => m.GetNewSchoolChoicesForStudent(paramMock.Object))
                    .Returns("<NewDataSet><StudentId></StudentId><SchoolId></SchoolId></NewDataSet>");

                var studentSchoolChoiceRepository = fakeRepository.Object;
                var returned = studentSchoolChoiceRepository?.GetNewSchoolChoicesForStudent(paramMock.Object);
                Assert.IsNotNull(returned);
            }
        }
    }
}
