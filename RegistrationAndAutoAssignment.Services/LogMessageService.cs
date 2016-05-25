using System;
using System.Collections;
using System.IO;
using System.Net;
using System.Text;
using RegistrationAutoAssignment.Services.Interfaces;
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
    public class LogMessageService : ILogMessageService, IDisposable, IServiceLayer
    {
        private bool _disposed;
        internal Hashtable UnitOfWorks { get; private set; }

        public IUnitOfWork UnitOfWork { get; }


        public LogMessageService(IUnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public LogMessageService()
        { }

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
                        $"StudentId: {logRequest?.StudentId}, AssignedSchoolId: {logRequest?.AssignedSchoolId} and TransferSchoolId:{logRequest?.TransferSchoolId}");
                }
            }
            else
            {
                var stream = fileInfo.OpenWrite();
                var info = new UTF8Encoding(true).GetBytes($"StudentId: {logRequest?.StudentId}, AssignedSchoolId: {logRequest?.AssignedSchoolId} and TransferSchoolId:{logRequest?.TransferSchoolId}");

                stream.Write(info,0,info.Length);
            }
            return HttpStatusCode.OK.ToString();
        }
    }
}

