using Microsoft.Practices.Unity;
using System.Web.Http;
using RegistrationAutoAssignment.Controllers;

using Unity.WebApi;
using RegistrationAutoAssignment.Services;
using RegistrationAutoAssignment.Services.Interfaces.Services;
using RegistrationAutoAssignment.Units.Interfaces;
using RegistrationAutoAssignment.Units.UnitOfWork;
using RegistrationAutoAssignment.Repositories;

namespace RegistrationAutoAssignment
{
	public static class UnityConfig
	{
		public static void RegisterComponents()
		{
			var container = new UnityContainer();

			// register all your components with the container here
			// it is NOT necessary to register your controllers
			// e.g. container.RegisterType<ITestService, TestService>();

			GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

            GetLogByServiceInterface(container);
			GetStdSchByServiceInterfaceWithUow(container);
		}

        /// <summary>
        /// Using Service interface with Unit of work creating the context and repositories.
        /// </summary>
        private static void GetStdSchByServiceInterfaceWithUow(IUnityContainer container)
        {
            container.RegisterType<IStudentSchoolChoicesUnitOfWork, StudentSchoolChoicesUnitOfWork>(new HierarchicalLifetimeManager(),
                new InjectionConstructor(typeof(DbContextFactory)));

            container.RegisterType<SchoolChoiceRepository>(new InjectionConstructor());
            container.RegisterType<SchoolCapacityRepository>(new InjectionConstructor(typeof(StudentSchoolChoicesUnitOfWork)));
            container.RegisterType<SchoolWaitListRepository>(new InjectionConstructor(typeof(StudentSchoolChoicesUnitOfWork)));

            container.RegisterType<IStudentSchoolChoicesService, StudentSchoolChoicesService>(
                new InjectionConstructor(typeof(IStudentSchoolChoicesUnitOfWork), typeof(SchoolChoiceRepository),
                    typeof(SchoolCapacityRepository), typeof(SchoolWaitListRepository)));

            container.RegisterType<StudentSchoolChoiceController>(
                new InjectionConstructor(typeof(IStudentSchoolChoicesService)));



        }


	    /// <summary>
		/// Using Service Interface 
		/// </summary>
		/// <param name="container"></param>
		private static void GetLogByServiceInterface(IUnityContainer container)
		{
			container.RegisterType<LogController>(new InjectionConstructor(typeof(ILogMessageService)))
						.RegisterType<ILogMessageService, LogMessageService>(new InjectionConstructor());
		}
	}
}