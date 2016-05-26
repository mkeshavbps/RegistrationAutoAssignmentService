using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using System.Data.EntityClient;
using System.Data.SqlClient;
using Moq;
using RegistrationAutoAssignment.Entities;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Repositories.Tests.Interfaces;


namespace RegistrationAutoAssignment.Repositories.Tests
{
    [TestClass]
    public class TestStudentSchoolChoiceRepository 
    {
        public DbConnection CntxDbConnect { get; private set; }
        public ExtractAspenEntities ContextUsingDbConnect { get; private set; }
        public EntityConnection CntxEntityConnect { get; private set; }
        public ExtractAspenEntities ContextUsingEntityConnect { get; private set; }
        public ISchoolChoicesRepository Repository { get; private set; }
        public List<STUDENT> Students { get; private set; }
        public Mock<IFakeStudentSchoolChoiceRepository> FakeStudentSchoolChoiceMock { get; private set; }

        [TestInitialize]
        public void RepositoryInitialize()
        {
            Students = new List<STUDENT>();
            CntxDbConnect = Effort.DbConnectionFactory.CreateTransient();
            ContextUsingDbConnect = new ExtractAspenEntities(CntxDbConnect);

            // Specify the provider name, server and database.
            const string providerName = "System.Data.SqlClient";
            const string serverName = "APPSSQL";
            const string databaseName = "ExtractAspen";

            // Initialize the connection string builder for the
            // underlying provider.
            // Set the properties for the data source.
            var sqlBuilder =
                new SqlConnectionStringBuilder
                {
                    DataSource = serverName,
                    InitialCatalog = databaseName,
                    IntegratedSecurity = true
                };

            // Build the SqlConnection connection string.
            var providerString = sqlBuilder.ToString();

            // Initialize the EntityConnectionStringBuilder.
            var entityBuilder =
                new EntityConnectionStringBuilder
                {
                    Provider = providerName,
                    ProviderConnectionString = providerString,
                    Metadata = @"res://*/ExtractAspen.csdl|res://*/ExtractAspen.ssdl|res://*/ExtractAspen.msl"
                };

            CntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient(entityBuilder.ToString());

            #region "Different implemenation"

            //_cntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient("name=ExtractAspenEntities");
            //_cntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient(new EntityConnectionStringBuilder().ToString());
            //_cntxEntityConnect =
            //    Effort.EntityConnectionFactory.CreateTransient(BuildEntityConnString("localDb", "ExtractAspen",
            //        string.Empty));

            #endregion

            ContextUsingEntityConnect = new ExtractAspenEntities(CntxEntityConnect);
            Repository = new SchoolChoiceRepository(CntxDbConnect);

        }

        /// <summary>
        /// Mocking the repository pattern
        /// by creating a new student and adding the student
        /// </summary>
        /// <returns></returns>
        public Mock<IFakeStudentSchoolChoiceRepository> StudentScoolChoicesRepositoryFake()
        {
            FakeStudentSchoolChoiceMock = new Mock<IFakeStudentSchoolChoiceRepository>();
            FakeStudentSchoolChoiceMock.Setup(x => x.AddStudent(It.IsAny<STUDENT>()))
                .Callback((STUDENT s) =>
                    {
                        Students.Add(s);
                    });
            FakeStudentSchoolChoiceMock.Setup(x => x.GetAllStudents).Returns(Students);
            return FakeStudentSchoolChoiceMock;

        }

        /// <summary>
        /// Test to assert the fake repository instance creation.
        /// </summary>
        [TestMethod]
        public void TestStudentSchoolRepositoryInstance()
        {
            FakeStudentSchoolChoiceMock = new Mock<IFakeStudentSchoolChoiceRepository>();
            Assert.IsNotNull(FakeStudentSchoolChoiceMock.Object);
        }

        /// <summary>
        /// Testing the web service call using Mock
        /// </summary>
        [TestMethod]
        public void TestStudentSchoolChoicesWebService()
        {
            FakeStudentSchoolChoiceMock = new Mock<IFakeStudentSchoolChoiceRepository>();
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

            FakeStudentSchoolChoiceMock.Setup(m => m.GetNewSchoolChoicesForStudent(paramMock.Object))
                .Returns("<NewDataSet><StudentId></StudentId><SchoolId></SchoolId></NewDataSet>");

            var returnedString = FakeStudentSchoolChoiceMock.Object?.GetNewSchoolChoicesForStudent(paramMock.Object);
            Assert.IsNotNull(returnedString);
        }

        /// <summary>
        /// Dispose all objects.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            Repository.Dispose();
            FakeStudentSchoolChoiceMock.Object.Dispose();

            ContextUsingEntityConnect.Dispose();
            ContextUsingDbConnect.Dispose();
        }

        #region "Implemented interface IFakeStudentSchoolChoiceRepository 

        public void AddStudent(STUDENT student)
        {
            FakeStudentSchoolChoiceMock.Object.AspenDbContext?.STUDENTs.Add(new STUDENT { STD_OID = "1234" });
        }
       
        public IEnumerable<STUDENT> GetAllStudents { get; set; }

        public ExtractAspenEntities AspenDbContext { get; set; }

        #endregion
    }

   

}
