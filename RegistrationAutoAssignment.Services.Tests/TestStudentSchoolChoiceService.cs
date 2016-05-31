using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RegistrationAutoAssignment.Services.Interfaces;
using RegistrationAutoAssignment.Services.Interfaces.Requests;
using RegistrationAutoAssignment.Setup;

namespace RegistrationAutoAssignment.Services.Tests
{
    [TestClass]
    public class TestStudentSchoolChoiceService
    {
        public InitializeEntityFramework Initialize { get; } = new InitializeEntityFramework();
        private Mock<IServiceLayer> MockedService { get; set; }
        private Mock<IStudentSchoolChoicesRequest> MockedRequest { get; set; }

        [TestInitialize]
        public void MoreToInitialize()
        {
            MockedService = new Mock<IServiceLayer>(MockBehavior.Default);
            MockedRequest = new Mock<IStudentSchoolChoicesRequest>();
        }

        [TestMethod]
        public void Test_StudentSchoolChoiceServiceInstance()
        {
            MockedService.Setup(m => m.InvokeService(MockedRequest.Object))
                .Returns("<NewDataSet></NewDataSet>");

            var returnedString = MockedService.Object.InvokeService(MockedRequest.Object);
            Assert.IsNotNull(MockedService);
            Assert.IsNotNull(MockedRequest);
            Assert.IsNotNull(returnedString);

        }

        [TestMethod]
        public void Test_StudentSchoolChoiceServiceInstance_InvokeWebServiceCall()
        {

            MockedService.Setup(m => m.InvokeService(MockedRequest.Object))
                .Returns("<NewDataSet></NewDataSet>");

            var returnedString = MockedService.Object.InvokeService(MockedRequest.Object);
            
            Assert.IsNotNull(returnedString);

        }
    }
}
