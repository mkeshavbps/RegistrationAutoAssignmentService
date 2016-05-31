using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using RegistrationAutoAssignment.Units.Interfaces;
using System.Web;
using RegistrationAutoAssignment.Services.Interfaces.Requests;
using RegistrationAutoAssignment.Services.Interfaces.Services;
using RegistrationAutoAssignment.Services.ServiceRequests;

namespace RegistrationAutoAssignment.Services
{
    /// <summary>
    /// This service container has a unit of work/s composed with one or more repositiories.
    /// </summary>
    public class LogMessageService : ILogMessageService
    {
        private bool _disposed;

        internal Hashtable AllUnitOfWorks { get; } = new Hashtable();

        public IUnitOfWork UnitOfWork { get; }

        public LogMessageService()
        { }


        public LogMessageService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
            AllUnitOfWorks?.Add(unitOfWork.GetType(), unitOfWork);
        }
        
        #region "IDisposable pattern"
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    Dispose();

            _disposed = true;
        }

        #endregion
        

        public string InvokeService(IRequest request)
        {
            var logRequest = request as LogMessageRequest;
            if (request == null) throw new ArgumentNullException(nameof(request));

            var path = HttpContext.Current.Server.MapPath("~/App_Data/FileLog.txt");

            var fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
            {
                using (var stream = new StreamWriter(path, true))
                {

                    stream.WriteLine(
                        $"DateTime: {DateTime.Now.ToLongTimeString()},StudentId: {logRequest?.StudentId}, AssignedSchoolId: {logRequest?.AssignedSchoolId} and TransferSchoolId:{logRequest?.TransferSchoolId}");
                }
            }
            else
            {
                using (var stream = fileInfo.AppendText())
                {
                    var info = new UTF8Encoding(true).GetBytes($" {stream.NewLine} DateTime: {DateTime.Now.ToLongTimeString()}, StudentId: {logRequest?.StudentId}, AssignedSchoolId: {logRequest?.AssignedSchoolId} and TransferSchoolId:{logRequest?.TransferSchoolId}");
                    stream.WriteAsync(Encoding.Default.GetString(info));
                }
            }
            return HttpStatusCode.OK.ToString();
        }
    }
}

