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
    
    public partial class GetStudentByToken_Result
    {
        public int STD_ID { get; set; }
        public string STD_LocalID { get; set; }
        public string STD_FamilyName { get; set; }
        public string STD_GivenName { get; set; }
        public string STD_MiddleName { get; set; }
        public System.DateTime STD_BirthDate { get; set; }
        public string STD_GradeLevel { get; set; }
        public int STD_AddressID { get; set; }
        public string STD_EmailAddress { get; set; }
        public string STD_EmailAddress2 { get; set; }
        public string STD_PhoneNumber { get; set; }
        public Nullable<bool> STD_IsAWC { get; set; }
        public Nullable<bool> STD_IsBAS { get; set; }
        public string STD_SNCode { get; set; }
        public string STD_LEPStatus { get; set; }
        public string STD_ELDLevel { get; set; }
        public string STD_SIFEStatus { get; set; }
        public string STD_FirstLang { get; set; }
        public Nullable<System.Guid> STD_RankedChoicesUsrID { get; set; }
        public Nullable<System.DateTime> STD_Type { get; set; }
        public string STD_CorrespLang { get; set; }
        public Nullable<int> RND_RoundNum { get; set; }
        public Nullable<System.DateTime> RND_RoundEndDate { get; set; }
    }
}
