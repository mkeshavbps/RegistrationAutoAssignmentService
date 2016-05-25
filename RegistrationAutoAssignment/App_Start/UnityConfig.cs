using Microsoft.Practices.Unity;
using System.Web.Http;
using RegistrationAutoAssignment.Controllers;
using Unity.WebApi;
using RegistrationAutoAssignment.Services;
using RegistrationAutoAssignment.Services.Interfaces.Services;

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

            //container.RegisterType<LogController>("interfaceLogMsgContr",
            //    new InjectionConstructor(typeof(ILogMessageService)));

            container.RegisterType<LogController>()
            .RegisterType<ILogMessageService, LogMessageService>();


            //container.RegisterType<StudentSchoolChoiceController>()
            //    .RegisterType<IStudentSchoolChoicesService, StudentSchoolChoicesService>("interfaceStdSchChoiceSvc", new InjectionConstructor(typeof(IStudentSchoolChoicesService)))
            //    .RegisterType<IUnitOfWork, StudentSchoolChoicesUnitOfWork>("intefaceStdSchChoiceUow", new InjectionConstructor(typeof(IStudentSchoolChoicesUnitOfWork)))
            //    .RegisterType<IRepository, SchoolChoiceRepository>("interfaceStdSchChoiceRepo", new InjectionConstructor(typeof(ISchoolChoicesRepository)));


        }
    }
}