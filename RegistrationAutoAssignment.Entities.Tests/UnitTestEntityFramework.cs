using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RegistrationAutoAssignment.Setup;

namespace RegistrationAutoAssignment.Entities.Tests
{
    [TestClass]
    public class UnitTestEntityFramework
    {
        private InitializeEntityFramework Initialize { get; } = new InitializeEntityFramework();

        [TestMethod]
        public void Test_GetSchools()
        {
            var newSchool1 = Initialize.ContextUsingDbConnect.SCHOOLs.Create();
            newSchool1.SKL_OID = "1234";
            newSchool1.SKL_SCHOOL_NAME = "ABC";

            var newSchool2 = Initialize.ContextUsingDbConnect.SCHOOLs.Create();
            newSchool2.SKL_OID = "12345";
            newSchool2.SKL_AD_OU_NAME = "XYZ";

            Initialize.ContextUsingDbConnect.SCHOOLs.Add(newSchool1);
            Initialize.ContextUsingDbConnect.SCHOOLs.Add(newSchool2);

            Assert.IsTrue(Initialize.ContextUsingDbConnect.SCHOOLs.Any(sch => sch.SKL_SCHOOL_NAME != null));
        }

        /// <summary>
        /// Asserts the retrieved shcool is NotNull
        /// Asserts expected and actual school are of the same instance type
        /// Asserts the value of the School Id is the same in the both expected and actual SCHOOL object.
        /// </summary>
        [TestMethod]
        public void Test_GetSchoolById()
        {
            var newSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");


            if (newSchool == null)
            {
                newSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.Create();
                newSchool.SKL_OID = "1234";
                Initialize.ContextUsingEntityConnect.SCHOOLs.Add(newSchool);
                Initialize.ContextUsingEntityConnect.SaveChanges();
            }
          
            
            var expectedSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            Assert.IsNotNull(expectedSchool);
            Assert.AreSame(expectedSchool, newSchool);
            Assert.AreEqual(expectedSchool.SKL_OID, newSchool.SKL_OID);
        }


        /// <summary>
        /// Assert the deletion of the school by School Id.
        /// Asserting after the deletion to  whether school IsNull.
        /// </summary>
        [TestMethod]
        public void Test_DeleteSchoolById()
        {
            var newSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            if (newSchool != null)
            {
                Initialize.ContextUsingEntityConnect.SCHOOLs.Remove(newSchool);
                Initialize.ContextUsingEntityConnect.SaveChanges();
            }


            var expectedSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            Assert.IsNull(expectedSchool);
        }


        /// <summary>
        /// UpdateSchool information by Id.
        /// Assert the value after the update is true.
        /// </summary>
        [TestMethod]
        public void Test_UpdateSchoolById()
        {
            var retrievedSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            if (retrievedSchool == null)
            {
                var newSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.Create();
                newSchool.SKL_OID = "1234";
                retrievedSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.Add(newSchool);
                Initialize.ContextUsingEntityConnect.SaveChanges();
            }

            //Find and make updates to entity.
            var schoolToUpdate = Initialize.ContextUsingEntityConnect.SCHOOLs.Find("1234");

            schoolToUpdate.SKL_SCHOOL_NAME = "My Test School Name";
            schoolToUpdate.SKL_AD_OU_NAME = "Testing";
            schoolToUpdate.SKL_NUMBER_OF_GRADES = 5.0m;
            schoolToUpdate.SKL_START_GRADE = 3.2m +0.1m;

            Initialize.ContextUsingEntityConnect.SaveChanges();


            var expectedSchool = Initialize.ContextUsingEntityConnect.SCHOOLs.SingleOrDefault(sch => sch.SKL_OID == "1234");

            Assert.IsNotNull(retrievedSchool);
            Assert.IsNotNull(expectedSchool);
            Assert.AreEqual(expectedSchool.SKL_SCHOOL_NAME, retrievedSchool.SKL_SCHOOL_NAME);
            Assert.AreEqual(expectedSchool.SKL_AD_OU_NAME, retrievedSchool.SKL_AD_OU_NAME);
            Assert.AreEqual(expectedSchool.SKL_NUMBER_OF_GRADES, retrievedSchool.SKL_NUMBER_OF_GRADES);
            Assert.AreNotEqual(expectedSchool.SKL_START_GRADE, retrievedSchool.SKL_START_GRADE);
        }
    }
}

