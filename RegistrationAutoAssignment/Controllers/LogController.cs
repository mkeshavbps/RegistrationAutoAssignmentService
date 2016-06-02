using System.Web.Http;
using RegistrationAutoAssignment.Attributes.Exceptions;
using RegistrationAutoAssignment.Services.Interfaces.Requests;
using RegistrationAutoAssignment.Services.Interfaces.Services;
using RegistrationAutoAssignment.Services.ServiceRequests;

namespace RegistrationAutoAssignment.Controllers
{
    [BpsException]
    public class LogController : ApiController
    {
        public IRequest MessageRequest { get; }

        internal ILogMessageService LogService { get; }

        public LogController(ILogMessageService service)
        {
            LogService = service;
        }

        public LogController(IRequest logMessageRequest)
        {
            MessageRequest = logMessageRequest;
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
