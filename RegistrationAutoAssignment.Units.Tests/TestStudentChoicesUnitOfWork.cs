using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Common;
using RegistrationAutoAssignment.Entities;
using System.Data.SqlClient;
using System.Data.EntityClient;
using Moq;
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
        public Mock<IUnitOfWork> Mock { get; private set; }

        [TestInitialize]
        public void UnitOfWorkInitialize()
        {
            //IDataLoader loader = new EntityDataLoader(); 
            //IDataLoader loader = new Effort.DataLoaders.CsvDataLoader(csvFiles);

            CntxDbConnect = Effort.DbConnectionFactory.CreateTransient();
            ContextUsingDbConnect = new ExtractAspenEntities(CntxDbConnect);

            Mock = new Mock<IUnitOfWork>(MockBehavior.Default);
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
        }
    }
}
