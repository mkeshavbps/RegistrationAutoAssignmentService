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
    
    public partial class REPORT_DELIVERY_JOB
    {
        public string RDJ_OID { get; set; }
        public string RDJ_RPT_OID { get; set; }
        public string RDJ_USR_OID { get; set; }
        public string RDJ_SKL_OID { get; set; }
        public Nullable<System.DateTime> RDJ_DATE { get; set; }
        public Nullable<System.DateTime> RDJ_TIME { get; set; }
        public Nullable<System.DateTime> RDJ_CLEANUP_DATE { get; set; }
        public Nullable<System.DateTime> RDJ_VIEW_START_DATE { get; set; }
        public Nullable<System.DateTime> RDJ_VIEW_END_DATE { get; set; }
        public string RDJ_PUBLISHED_IND { get; set; }
        public string RDJ_PUBLISHED_MESSAGE { get; set; }
        public string RDJ_PUBLISHED_SUBJECT { get; set; }
        public Nullable<decimal> RDJ_LAST_MODIFIED { get; set; }
    }
}
