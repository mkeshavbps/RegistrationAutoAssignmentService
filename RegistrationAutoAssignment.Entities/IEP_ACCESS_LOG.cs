//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationAutoAssignment.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class IEP_ACCESS_LOG
    {
        public string ILG_OID { get; set; }
        public string ILG_IEP_OID { get; set; }
        public string ILG_USR_OID { get; set; }
        public Nullable<System.DateTime> ILG_ACCESS_DATE { get; set; }
        public Nullable<System.DateTime> ILG_ACCESS_TIME { get; set; }
        public string ILG_LOGIN_NAME { get; set; }
        public string ILG_NAME_VIEW { get; set; }
        public Nullable<System.DateTime> ILG_IEP_START_DATE { get; set; }
        public Nullable<System.DateTime> ILG_IEP_END_DATE { get; set; }
        public Nullable<decimal> ILG_IEP_STATUS { get; set; }
        public Nullable<decimal> ILG_LAST_MODIFIED { get; set; }
    }
}
