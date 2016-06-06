using System.Web.Http;
using RegistrationAutoAssignment.Attributes.Exceptions;
using RegistrationAutoAssignment.Services.Interfaces.Services;
using RegistrationAutoAssignment.Services.ServiceRequests;

namespace RegistrationAutoAssignment.Controllers
{
    [BpsException]
    public class LogController : ApiController
    {
        private ILogMessageService LogService { get; }

        public LogController(ILogMessageService service)
        {
            LogService = service;
        }
    
        [HttpPost, ActionName("LogMessage")]
        public IHttpActionResult LogMessage([FromBody]LogMessageRequest request)
        {

            if (LogService == null)
                return NotFound();

            var returnString = LogService.InvokeService(request);

            return Ok(returnString);
        }
    }

    
}
