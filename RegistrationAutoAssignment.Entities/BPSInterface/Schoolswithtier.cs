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
    
    public partial class Schoolswithtier
    {
        public int SchYear { get; set; }
        public int Sch { get; set; }
        public Nullable<double> Tier { get; set; }
        public Nullable<bool> UseTierForHMB { get; set; }
        public Nullable<double> FeedsTo1 { get; set; }
        public Nullable<double> FeedsTo2 { get; set; }
        public Nullable<int> CapacitySchoolRank { get; set; }
        public string ELLCluster { get; set; }
        public Nullable<bool> IsCitywideChoice { get; set; }
        public Nullable<bool> IsEECChoice { get; set; }
        public Nullable<bool> IsFeeder1SameSch { get; set; }
        public Nullable<bool> DisplayTier { get; set; }
    }
}
