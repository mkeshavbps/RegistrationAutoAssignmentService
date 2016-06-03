using Microsoft.Practices.Unity;
using System.Web.Http;
using RegistrationAutoAssignment.Controllers;
using RegistrationAutoAssignment.Repositories;
using RegistrationAutoAssignment.Repositories.Interfaces;
using Unity.WebApi;
using RegistrationAutoAssignment.Services;
using RegistrationAutoAssignment.Services.Interfaces.Requests;
using RegistrationAutoAssignment.Services.Interfaces.Services;
using RegistrationAutoAssignment.Services.ServiceRequests;
using RegistrationAutoAssignment.Units.Interfaces;
using RegistrationAutoAssignment.Units.UnitOfWork;
using RegistrationAutoAssignment.Entities.ExtractAspen;

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

			GetLogByServiceInterfaceWithUow(container);
			GetStdSchByServiceInterfaceWithUow(container);
			//GetStdSchByServiceInterfaceWithRepository(container);
		}

        /// <summary>
        /// Using Service interface with Unit of work creating the context and repositories.
        /// </summary>
        private static void GetStdSchByServiceInterfaceWithUow(IUnityContainer container)
        {
            container.RegisterType<StudentSchoolChoiceController>(
                new InjectionConstructor(typeof(IStudentSchoolChoicesService)))
                .RegisterType<IStudentSchoolChoicesService, StudentSchoolChoicesService>(
                    new InjectionConstructor(typeof(IStudentSchoolChoicesUnitOfWork)))
                .RegisterType<IStudentSchoolChoicesUnitOfWork, StudentSchoolChoicesUnitOfWork>(
                    new InjectionConstructor(typeof(DbContextFactory), typeof(SchoolChoiceRepository),
                        typeof(SchoolWaitListRepository)));
           

        }


        /// <summary>
        /// Using Service interface with Unit of work creating the context and repositories.
        /// </summary>
        //private static void GetStdSchByServiceInterfaceWithRepository(IUnityContainer container)
		//{
		//	container.RegisterType<StudentSchoolChoiceController>(new InjectionConstructor(typeof(IStudentSchoolChoicesService)))
		//		.RegisterType<IStudentSchoolChoicesService, StudentSchoolChoicesService>(new InjectionConstructor(typeof(IRepository)))
		//				.RegisterType<IRepository, SchoolWaitListRepository>(new InjectionConstructor());
		//}

		/// <summary>
		/// Using Request Interface
		/// </summary>
		/// <param name="container"></param>
		private static void GetLogByRequestInterface(IUnityContainer container)
		{
			container.RegisterType<LogController>(new InjectionConstructor(typeof(IRequest)))
				.RegisterType<IRequest, LogMessageRequest>(new HierarchicalLifetimeManager());
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

		/// <summary>
		/// Using Service interface with Unit of work creating the context and repositories.
		/// </summary>
		/// <param name="container"></param>
		private static void GetLogByServiceInterfaceWithUow(IUnityContainer container)
		{
			container.RegisterType<LogController>(new InjectionConstructor(typeof(ILogMessageService)))
				.RegisterType<ILogMessageService, LogMessageService>(new InjectionConstructor(typeof(IUnitOfWork)))
					.RegisterType<IUnitOfWork, LogMessageUnitOfWork>(new InjectionConstructor());

		}
	}
}