using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using RegistrationAutoAssignment.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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

        [TestInitialize]
        public void EntityFrameworkInitialize()
        {
            //IDataLoader loader = new EntityDataLoader(); 
            //IDataLoader loader = new Effort.DataLoaders.CsvDataLoader(csvFiles);

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
            //_cntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient("name=ExtractAspenEntities");
            //_cntxEntityConnect = Effort.EntityConnectionFactory.CreateTransient(new EntityConnectionStringBuilder().ToString());
            //_cntxEntityConnect =
            //    Effort.EntityConnectionFactory.CreateTransient(BuildEntityConnString("localDb", "ExtractAspen",
            //        string.Empty));

            ContextUsingEntityConnect = new ExtractAspenEntities(CntxEntityConnect);
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
            CntxDbConnect.Dispose();
            CntxEntityConnect.Dispose();
            ContextUsingEntityConnect.Dispose();
            ContextUsingDbConnect.Dispose();
        }
    }
}