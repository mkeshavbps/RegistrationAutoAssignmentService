using System;
using System.Web.Http.Filters;
using NLog;

namespace RegistrationAutoAssignment.Attributes.Exceptions
{

    [AttributeUsage(AttributeTargets.All)]
    public class BpsExceptionAttribute : ExceptionFilterAttribute
    {
        /// <summary>
        /// Logs all the error - including unhandled exception
        /// </summary>
        /// <param name="actionExecutedContext"></param>
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            var logger = LogManager.GetCurrentClassLogger();
            logger.Error(actionExecutedContext.Exception);
            base.OnException(actionExecutedContext);
        }
    }
}