using System.ComponentModel.DataAnnotations;
using RegistrationAutoAssignment.Services.Interfaces.Requests;

namespace RegistrationAutoAssignment.Services.ServiceRequests
{
    public class LogMessageRequest : IRequest
    {
        /// <summary>
        /// Student Id.
        /// </summary>
        [Required]
        public int StudentId { get; set; }

        /// <summary>
        /// This affects the actual count in the SCHOOL_CAPACITY table.
        /// </summary>
        [Required]
        public int AssignedSchoolId { get; set; }

        /// <summary>
        /// This affects the assigned count in the SCHOOL_CAPACITY table.
        /// </summary>
        [Required]
        public int TransferSchoolId { get; set; }

        public string ClientCode { get; set; }
    }

    
}
