//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationAutoAssignment.Entities.BPSInterface
{
    using System;
    using System.Collections.Generic;
    
    public partial class usrUserSession
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public usrUserSession()
        {
            this.Students = new HashSet<Student>();
        }
    
        public System.Guid usrID { get; set; }
        public int usrStdId { get; set; }
        public string usrSTD_EmailAddress { get; set; }
        public System.DateTime usrAuthenticationRequest { get; set; }
        public string usrPasscode { get; set; }
        public Nullable<System.DateTime> usrAuthenticationApprove { get; set; }
        public string usrVerification { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student> Students { get; set; }
    }
}
