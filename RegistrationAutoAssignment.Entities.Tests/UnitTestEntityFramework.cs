using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

//using NMemory.Linq;
//using Effort.DataLoaders;

namespace RegistrationAutoAssignment.Entities.Tests
{
    [TestClass]
    public class UnitTestEntityFramework
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

        [TestMethod]
        public void GetSchools()
        {
            var newSchool1 = ContextUsingDbConnect.SCHOOLs.Create();
            newSchool1.SKL_OID = "1234";
            newSchool1.SKL_SCHOOL_NAME = "ABC";

            var newSchool2 = ContextUsingDbConnect.SCHOOLs.Create();
            newSchool2.SKL_OID = "12345";
            newSchool2.SKL_AD_OU_NAME = "XYZ";

            ContextUsingDbConnect.SCHOOLs.Add(newSchool1);
            ContextUsingDbConnect.SCHOOLs.Add(newSchool2);

            Assert.IsTrue(ContextUsingDbConnect.SCHOOLs.All(sch => sch.SKL_SCHOOL_NAME != null));
        }

        /// <summary>
        /// Asserts the retrieved shcool is NotNull
        /// Asserts expected and actual school are of the same instance type
        /// Asserts the value of the School Id is the same in the both expected and actual SCHOOL object.
        /// </summary>
        [TestMethod]
        public void GetSchoolById()
        {
            var newSchool = ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");


            if (newSchool == null)
            {
                newSchool = ContextUsingEntityConnect.SCHOOLs.Create();
                newSchool.SKL_OID = "1234";
                ContextUsingEntityConnect.SCHOOLs.Add(newSchool);
                ContextUsingEntityConnect.SaveChanges();
            }
          
            
            var expectedSchool = ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            Assert.IsNotNull(expectedSchool);
            Assert.AreSame(expectedSchool, newSchool);
            Assert.AreEqual((object) expectedSchool.SKL_OID, newSchool.SKL_OID);
        }


        /// <summary>
        /// Assert the deletion of the school by School Id.
        /// Asserting after the deletion to  whether school IsNull.
        /// </summary>
        [TestMethod]
        public void DeleteSchoolById()
        {
            var newSchool = ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            if (newSchool != null)
            {
                ContextUsingEntityConnect.SCHOOLs.Remove(newSchool);
                ContextUsingEntityConnect.SaveChanges();
            }


            var expectedSchool = ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            Assert.IsNull(expectedSchool);
        }


        /// <summary>
        /// UpdateSchool information by Id.
        /// Assert the value after the update is true.
        /// </summary>
        [TestMethod]
        public void UpdateSchoolById()
        {
            var retrievedSchool = ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            if (retrievedSchool == null)
            {
                var newSchool = ContextUsingEntityConnect.SCHOOLs.Create();
                newSchool.SKL_OID = "1234";
                retrievedSchool = ContextUsingEntityConnect.SCHOOLs.Add(newSchool);
                ContextUsingEntityConnect.SaveChanges();
            }

            //Find and make updates to entity.
            var schoolToUpdate = ContextUsingEntityConnect.SCHOOLs.Find("1234");

            schoolToUpdate.SKL_SCHOOL_NAME = "My Test School Name";
            schoolToUpdate.SKL_AD_OU_NAME = "Testing";
            schoolToUpdate.SKL_NUMBER_OF_GRADES = 5.0m;
            schoolToUpdate.SKL_START_GRADE = 3.2m;


            ContextUsingEntityConnect.SCHOOLs.AddOrUpdate(schoolToUpdate);
            ContextUsingEntityConnect.SaveChanges();


            var expectedSchool = ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            Assert.IsNotNull(retrievedSchool);
            Assert.IsNotNull(expectedSchool);
            Assert.AreEqual(expectedSchool.SKL_SCHOOL_NAME, retrievedSchool.SKL_SCHOOL_NAME);
            Assert.AreEqual(expectedSchool.SKL_AD_OU_NAME, retrievedSchool.SKL_AD_OU_NAME);
            Assert.AreEqual(expectedSchool.SKL_NUMBER_OF_GRADES, retrievedSchool.SKL_NUMBER_OF_GRADES);
            Assert.AreEqual(expectedSchool.SKL_START_GRADE, retrievedSchool.SKL_START_GRADE);
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

