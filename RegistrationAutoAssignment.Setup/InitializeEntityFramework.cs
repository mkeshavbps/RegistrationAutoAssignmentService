using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using RegistrationAutoAssignment.Entities.ExtractAspen;
using RegistrationAutoAssignment.Repositories;
using RegistrationAutoAssignment.Units.UnitOfWork;
using RegistrationAutoAssignment.Repositories.Interfaces;
using RegistrationAutoAssignment.Units.Interfaces;
using RegistrationAutoAssignment.Services.Interfaces;

//using NMemory.Linq;
//using Effort.DataLoaders;

namespace RegistrationAutoAssignment.Setup
{
    public class InitializeEntityFramework
    {
        public DbConnection CntxDbConnect { get; private set; }
        public ExtractAspenEntities ContextUsingDbConnect { get; private set; }
        public System.Data.EntityClient.EntityConnection CntxEntityConnect { get; private set; }
        public ExtractAspenEntities ContextUsingEntityConnect { get; private set; }

        public IUnitOfWork UnitOfWork { get; private set; }
        public IRepository Repository { get; private set; }

        public Mock<IFakeUnitOfWork> MockedUnitOfWork { get; private set; }

        public Mock<IServiceLayer> MockedService { get; private set; }


        public InitializeEntityFramework()
        {
            EntityFrameworkInitialize();
        }

        [TestInitialize]
        public void EntityFrameworkInitialize()
        {
            //IDataLoader loader = new EntityDataLoader(); 
            //IDataLoader loader = new Effort.DataLoaders.CsvDataLoader(csvFiles);

            CntxDbConnect = Effort.DbConnectionFactory.CreateTransient();
            ContextUsingDbConnect = new ExtractAspenEntities(CntxDbConnect);

            MockedUnitOfWork = new Mock<IFakeUnitOfWork>(MockBehavior.Default);
            UnitOfWork = new StudentSchoolChoicesUnitOfWork(CntxDbConnect);

            MockedService = new Mock<IServiceLayer>(MockBehavior.Default);

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
                    Metadata = @"res://*/ExtractAspen.ExtractAspen.csdl|res://*/ExtractAspen.ExtractAspen.ssdl|res://*/ExtractAspen.ExtractAspen.msl"
                };

            CntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient(entityBuilder.ToString());
            //_cntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient("name=ExtractAspenEntities");
            //_cntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient(new EntityConnectionStringBuilder().ToString());
            //_cntxEntityConnect =
            //    Effort.EntityConnectionFactory.CreateTransient(BuildEntityConnString("ExtractAspen", "ExtractAspen.ExtractAspen",
            //        string.Empty));

            ContextUsingEntityConnect = new ExtractAspenEntities(CntxEntityConnect);
            Repository = new SchoolChoiceRepository(CntxDbConnect);
        }

        /// <summary>
        /// helper to build entity connection
        /// </summary>
        /// <param name="dbFileName"></param>
        /// <param name="resourceData"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private static string BuildEntityConnString(string dbFileName, string resourceData, string password)
        {
            const string resAll = @"res://*/";
            var dataSource = @"Data Source=" + dbFileName;
            var entityBuilder = new EntityConnectionStringBuilder
            {
                Metadata = string.Format("{0}{1}.csdl|{0}{1}.ssdl|{0}{1}.msl", resAll, resourceData),
                Provider = "System.Data.SqlClient",
                ProviderConnectionString = string.IsNullOrEmpty(password)
                    ? dataSource
                    : dataSource + ";Password=" + password
            };
            using (var con = new EntityConnection())
            {
                try
                {
                    con.ConnectionString = entityBuilder.ToString();
                    return con.ConnectionString;
                }
                finally
                { con.Close(); }
               
            }
        }
      

        /// <summary>
        /// Disposes the connection and context objects.
        /// </summary>
        [TestCleanup]
        public void CleanUp()
        {
            CntxDbConnect?.Dispose();
            CntxEntityConnect?.Dispose();
            ContextUsingEntityConnect?.Dispose();
            ContextUsingDbConnect?.Dispose();
            Repository?.Dispose();
            UnitOfWork?.Dispose();
        }
    }

    #region "Interface"

    /// <summary>
    /// Mock interface to invoke the service call.
    /// </summary>
    public interface IFakeRepository : ISchoolChoicesRepository
    { }

    public interface IFakeUnitOfWork : IStudentSchoolChoicesUnitOfWork
    { }

    public interface IFakeService : IServiceLayer
    { }

    #endregion
}