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
    
    public partial class LICENSE
    {
        public string LIC_OID { get; set; }
        public string LIC_TYPE { get; set; }
        public string LIC_PRODUCT { get; set; }
        public string LIC_FAMILY { get; set; }
        public string LIC_REG_ID { get; set; }
        public string LIC_PARENT_ID { get; set; }
        public string LIC_CUSTOMER_ID { get; set; }
        public string LIC_DESCRIPTION { get; set; }
        public string LIC_NOTES { get; set; }
        public Nullable<decimal> LIC_UNITS { get; set; }
        public Nullable<System.DateTime> LIC_VALID_FROM { get; set; }
        public Nullable<System.DateTime> LIC_VALID_THROUGH { get; set; }
        public Nullable<decimal> LIC_GRACE_PERIOD_HOURS { get; set; }
        public Nullable<decimal> LIC_RENEW_REMINDER_DAYS { get; set; }
        public Nullable<decimal> LIC_REFRESH_PERIOD_HOURS { get; set; }
        public string LIC_PROPERTIES { get; set; }
        public string LIC_SIGNATURE { get; set; }
        public Nullable<decimal> LIC_LAST_MODIFIED { get; set; }
    }
}
