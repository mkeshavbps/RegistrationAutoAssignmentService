using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using RegistrationAutoAssignment.Entities;
using System.Data.SqlClient;
using System.Data.EntityClient;
using Moq;
using RegistrationAutoAssignment.Repositories;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;
using RegistrationAutoAssignment.Units.UnitOfWork;

namespace RegistrationAutoAssignment.Units.Tests
{
    [TestClass]
    public class TestStudentChoicesUnitOfWork
    {
        public DbConnection CntxDbConnect { get; private set; }
        public ExtractAspenEntities ContextUsingDbConnect { get; private set; }
        public EntityConnection CntxEntityConnect { get; private set; }
        public ExtractAspenEntities ContextUsingEntityConnect { get; private set; }

        public IUnitOfWork UnitOfWork { get; private set; }
        public Mock<IUnitOfWork> Mocked { get; private set; }

        [TestInitialize]
        public void UnitOfWorkInitialize()
        {
            //IDataLoader loader = new EntityDataLoader(); 
            //IDataLoader loader = new Effort.DataLoaders.CsvDataLoader(csvFiles);
            
            CntxDbConnect = Effort.DbConnectionFactory.CreateTransient();
            ContextUsingDbConnect = new ExtractAspenEntities(CntxDbConnect);

            Mocked = new Mock<IUnitOfWork>(MockBehavior.Default);
            UnitOfWork = new StudentSchoolChoicesUnitOfWork(CntxDbConnect);
            

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
            //_cntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient("name=ExtractAspenEntities");
            //_cntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient(new EntityConnectionStringBuilder().ToString());
            //_cntxEntityConnect =
            //    Effort.EntityConnectionFactory.CreateTransient(BuildEntityConnString("localDb", "ExtractAspen",
            //        string.Empty));

            ContextUsingEntityConnect = new ExtractAspenEntities(CntxEntityConnect);
        }

        [TestMethod]
        public void TestMethod1()
        {
            using (var studentSchoolChoiceRepository = Mocked.Object.Repository as IFakeRepository)
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
             
                 var returned = studentSchoolChoiceRepository?.GetNewSchoolChoicesForStudent(paramMock.Object);
                Assert.IsNotNull(returned);
            }
        }

        [TestCleanup]
        public void CleanUp()
        {
            ContextUsingEntityConnect.Dispose();
            ContextUsingDbConnect.Dispose();
        }


        /// <summary>
        /// Mock interface to invoke the service call.
        /// </summary>
        public interface IFakeRepository : ISchoolChoicesRepository
        {
            
            
        }

        
    }
}
