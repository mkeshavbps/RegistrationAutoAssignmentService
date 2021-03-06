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
    
    public partial class StudentSchoolChoice
    {
        public int sscId { get; set; }
        public int sscSccId { get; set; }
        public string sscSSS_OID { get; set; }
        public string sscSCA_OID { get; set; }
        public Nullable<System.DateTime> sscSSS_LAST_MODIFIED { get; set; }
        public System.DateTime sscLastUpdate { get; set; }
        public Nullable<int> sscCallId { get; set; }
        public string sscSchoolId { get; set; }
        public string sscProgramId { get; set; }
        public string sscGradeLevel { get; set; }
        public string sscSchoolEligiblity { get; set; }
        public string sscTransportationEligbility { get; set; }
        public Nullable<double> sscWalkDistance { get; set; }
        public Nullable<double> sscStraightLineDistnace { get; set; }
        public Nullable<int> sscRank { get; set; }
        public string sscReviewStatus { get; set; }
        public Nullable<System.DateTime> sscReviewDate { get; set; }
        public Nullable<int> sscScaId { get; set; }
    
        public virtual SchoolCapacity SchoolCapacity { get; set; }
        public virtual SchoolChoicesForStudentCallInfo SchoolChoicesForStudentCallInfo { get; set; }
        public virtual SchoolChoicesForStudentCallResult SchoolChoicesForStudentCallResult { get; set; }
        public virtual StudentChoiceCase StudentChoiceCase { get; set; }
    }
}
