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
    
    public partial class SchoolChoicesForStudentCallInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SchoolChoicesForStudentCallInfo()
        {
            this.StudentSchoolChoices = new HashSet<StudentSchoolChoice>();
        }
    
        public int CallID { get; set; }
        public string SchYear { get; set; }
        public string type { get; set; }
        public string Studentno { get; set; }
        public string CaseID { get; set; }
        public Nullable<int> AddressIDParam { get; set; }
        public string GeoParam { get; set; }
        public string GradeParam { get; set; }
        public Nullable<System.DateTime> DOBParam { get; set; }
        public string ProgramCodeList { get; set; }
        public Nullable<bool> IsAWCParam { get; set; }
        public Nullable<bool> IsBASParam { get; set; }
        public string SNCodeParam { get; set; }
        public string LepStatusParam { get; set; }
        public string ELDLevelParam { get; set; }
        public string SifeStatusParam { get; set; }
        public string FirstLangParam { get; set; }
        public Nullable<int> SchYearInt { get; set; }
        public Nullable<bool> SplitSnowdenSubchoices { get; set; }
        public Nullable<bool> IsSchoolListOnly { get; set; }
        public Nullable<int> CurrentSchoolYear { get; set; }
        public Nullable<System.DateTime> SchYearCutoff { get; set; }
        public Nullable<bool> IsTwoWayPartOfChoiceList { get; set; }
        public Nullable<bool> IsAWC { get; set; }
        public Nullable<bool> IsBAS { get; set; }
        public string SNCode { get; set; }
        public string LepStatus { get; set; }
        public string ELDLevel { get; set; }
        public string SifeStatus { get; set; }
        public string FirstLang { get; set; }
        public Nullable<int> AddressID { get; set; }
        public string Geo { get; set; }
        public string Grade { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<bool> isExtendedDay { get; set; }
        public Nullable<bool> isTwoWay { get; set; }
        public Nullable<bool> isSpedIntegrated { get; set; }
        public Nullable<bool> isMontessori { get; set; }
        public Nullable<bool> isHybrid { get; set; }
        public string Voced { get; set; }
        public Nullable<bool> IsBataOnly { get; set; }
        public Nullable<bool> IsMadisonPark { get; set; }
        public string SEICode { get; set; }
        public Nullable<System.DateTime> BataThreshhold { get; set; }
        public string proposedSNCode { get; set; }
        public Nullable<bool> IsSubSepSped { get; set; }
        public string StuCluster { get; set; }
        public string stuZone { get; set; }
        public string StuZipCode { get; set; }
        public Nullable<double> addressX { get; set; }
        public Nullable<double> addressY { get; set; }
        public Nullable<bool> GetsInternationalHigh { get; set; }
        public string StuCurrentSchool { get; set; }
        public string StuCurrentProgramCode { get; set; }
        public string StuGuaranteeSchool1 { get; set; }
        public string StuGuaranteeProgCode1 { get; set; }
        public string StuGuaranteeSchool2 { get; set; }
        public string StuGuaranteeProgCode2 { get; set; }
        public Nullable<bool> isFeederSameSch { get; set; }
        public Nullable<int> NumWalkingDistanceFound { get; set; }
        public string siblingSchoolInfo { get; set; }
        public Nullable<System.DateTime> CallTime { get; set; }
        public string SP_Version { get; set; }
        public string TierVer { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentSchoolChoice> StudentSchoolChoices { get; set; }
    }
}
