﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RegistrationAutoAssignment.Repositories.StudentSchoolChoices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentSchoolChoices.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetData", ReplyAction="http://tempuri.org/IService/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSchoolSelections", ReplyAction="http://tempuri.org/IService/GetSchoolSelectionsResponse")]
        string GetSchoolSelections(string SchoolYear, string Grade, string Street, string StreetNumber, string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSchoolSelections", ReplyAction="http://tempuri.org/IService/GetSchoolSelectionsResponse")]
        System.Threading.Tasks.Task<string> GetSchoolSelectionsAsync(string SchoolYear, string Grade, string Street, string StreetNumber, string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSchoolSelectionsForAspen", ReplyAction="http://tempuri.org/IService/GetSchoolSelectionsForAspenResponse")]
        string GetSchoolSelectionsForAspen(string schoolYear, string geo, string StreetNumber, string Street, string ZipCode, string Grade, string MyGroup, string Schools, string dob, string isAWC, string isBilingual, string BilCode, string SnCode, string isBAS, string isSifeProgram);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSchoolSelectionsForAspen", ReplyAction="http://tempuri.org/IService/GetSchoolSelectionsForAspenResponse")]
        System.Threading.Tasks.Task<string> GetSchoolSelectionsForAspenAsync(string schoolYear, string geo, string StreetNumber, string Street, string ZipCode, string Grade, string MyGroup, string Schools, string dob, string isAWC, string isBilingual, string BilCode, string SnCode, string isBAS, string isSifeProgram);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetGeoList", ReplyAction="http://tempuri.org/IService/GetGeoListResponse")]
        string GetGeoList(string Street, string StreetNumber, string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetGeoList", ReplyAction="http://tempuri.org/IService/GetGeoListResponse")]
        System.Threading.Tasks.Task<string> GetGeoListAsync(string Street, string StreetNumber, string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetGeoListNew", ReplyAction="http://tempuri.org/IService/GetGeoListNewResponse")]
        string GetGeoListNew(string Street, string StreetNumber, string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetGeoListNew", ReplyAction="http://tempuri.org/IService/GetGeoListNewResponse")]
        System.Threading.Tasks.Task<string> GetGeoListNewAsync(string Street, string StreetNumber, string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAssignmentWalkEligibilityStatusByGeoCode", ReplyAction="http://tempuri.org/IService/GetAssignmentWalkEligibilityStatusByGeoCodeResponse")]
        string GetAssignmentWalkEligibilityStatusByGeoCode(string GeoCode, string SchoolYear, string SchoolCode, string Grade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAssignmentWalkEligibilityStatusByGeoCode", ReplyAction="http://tempuri.org/IService/GetAssignmentWalkEligibilityStatusByGeoCodeResponse")]
        System.Threading.Tasks.Task<string> GetAssignmentWalkEligibilityStatusByGeoCodeAsync(string GeoCode, string SchoolYear, string SchoolCode, string Grade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAssignmentWalkEligibilityStatusByAddress", ReplyAction="http://tempuri.org/IService/GetAssignmentWalkEligibilityStatusByAddressResponse")]
        string GetAssignmentWalkEligibilityStatusByAddress(string StreetNumber, string Street, string ZipCode, string SchoolYear, string SchoolCode, string Grade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAssignmentWalkEligibilityStatusByAddress", ReplyAction="http://tempuri.org/IService/GetAssignmentWalkEligibilityStatusByAddressResponse")]
        System.Threading.Tasks.Task<string> GetAssignmentWalkEligibilityStatusByAddressAsync(string StreetNumber, string Street, string ZipCode, string SchoolYear, string SchoolCode, string Grade);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSchoolSelectionsForStudents", ReplyAction="http://tempuri.org/IService/GetSchoolSelectionsForStudentsResponse")]
        string GetSchoolSelectionsForStudents(string schoolYear, string GeoCode, string Grade, string dob, string isAWC, string isBAS, string LEPStatus, string ELDScore, string SifeLevel, string FirstLanguage, string SNCode, string AssignSchForGuarantee, string AssignGradeForGuarantee, string AsignProgramForGuarantee, string IncludeIntHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSchoolSelectionsForStudents", ReplyAction="http://tempuri.org/IService/GetSchoolSelectionsForStudentsResponse")]
        System.Threading.Tasks.Task<string> GetSchoolSelectionsForStudentsAsync(string schoolYear, string GeoCode, string Grade, string dob, string isAWC, string isBAS, string LEPStatus, string ELDScore, string SifeLevel, string FirstLanguage, string SNCode, string AssignSchForGuarantee, string AssignGradeForGuarantee, string AsignProgramForGuarantee, string IncludeIntHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSchoolSelectionsForStudent", ReplyAction="http://tempuri.org/IService/GetSchoolSelectionsForStudentResponse")]
        string GetSchoolSelectionsForStudent(string schoolYear, string GeoCode, string Grade, string dob, string isAWC, string isBAS, string LEPStatus, string ELDScore, string SifeLevel, string FirstLanguage, string SNCode, string AssignSchForGuarantee, string AssignGradeForGuarantee, string AsignProgramForGuarantee, string IncludeIntHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetSchoolSelectionsForStudent", ReplyAction="http://tempuri.org/IService/GetSchoolSelectionsForStudentResponse")]
        System.Threading.Tasks.Task<string> GetSchoolSelectionsForStudentAsync(string schoolYear, string GeoCode, string Grade, string dob, string isAWC, string isBAS, string LEPStatus, string ELDScore, string SifeLevel, string FirstLanguage, string SNCode, string AssignSchForGuarantee, string AssignGradeForGuarantee, string AsignProgramForGuarantee, string IncludeIntHigh);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetProgramCodeFromEnrollmentFields", ReplyAction="http://tempuri.org/IService/GetProgramCodeFromEnrollmentFieldsResponse")]
        string GetProgramCodeFromEnrollmentFields(string SchoolYear, string School, string grade, string SeiCode, string SNCode, string isAWC, string Voced, string isExtendedDay, string isTwoWay, string isSpedIntegrated, string isMontessori, string isSife, string isHybrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetProgramCodeFromEnrollmentFields", ReplyAction="http://tempuri.org/IService/GetProgramCodeFromEnrollmentFieldsResponse")]
        System.Threading.Tasks.Task<string> GetProgramCodeFromEnrollmentFieldsAsync(string SchoolYear, string School, string grade, string SeiCode, string SNCode, string isAWC, string Voced, string isExtendedDay, string isTwoWay, string isSpedIntegrated, string isMontessori, string isSife, string isHybrid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetNewSchoolChoicesForStudent", ReplyAction="http://tempuri.org/IService/GetNewSchoolChoicesForStudentResponse")]
        string GetNewSchoolChoicesForStudent(
                    string SchoolYear, 
                    string Type, 
                    string StudentNo, 
                    string CaseID, 
                    string AddressID, 
                    string GeoParam, 
                    string GradeParam, 
                    string DOBparam, 
                    string ProgramCodeList, 
                    string IsAWCParam, 
                    string IsBASParam, 
                    string SNCodeParam, 
                    string LepStatusParam, 
                    string ELDLevelParam, 
                    string SifeStatusParam, 
                    string FirstLangParam, 
                    string SiblingsList, 
                    string TierVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetNewSchoolChoicesForStudent", ReplyAction="http://tempuri.org/IService/GetNewSchoolChoicesForStudentResponse")]
        System.Threading.Tasks.Task<string> GetNewSchoolChoicesForStudentAsync(
                    string SchoolYear, 
                    string Type, 
                    string StudentNo, 
                    string CaseID, 
                    string AddressID, 
                    string GeoParam, 
                    string GradeParam, 
                    string DOBparam, 
                    string ProgramCodeList, 
                    string IsAWCParam, 
                    string IsBASParam, 
                    string SNCodeParam, 
                    string LepStatusParam, 
                    string ELDLevelParam, 
                    string SifeStatusParam, 
                    string FirstLangParam, 
                    string SiblingsList, 
                    string TierVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetNewSchoolInterestListForStudent", ReplyAction="http://tempuri.org/IService/GetNewSchoolInterestListForStudentResponse")]
        string GetNewSchoolInterestListForStudent(
                    string SchoolYear, 
                    string Type, 
                    string StudentNo, 
                    string CaseID, 
                    string AddressID, 
                    string GeoParam, 
                    string GradeParam, 
                    string DOBparam, 
                    string ProgramCodeList, 
                    string IsAWCParam, 
                    string IsBASParam, 
                    string SNCodeParam, 
                    string LepStatusParam, 
                    string ELDLevelParam, 
                    string SifeStatusParam, 
                    string FirstLangParam, 
                    string SiblingsList, 
                    string TierVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetNewSchoolInterestListForStudent", ReplyAction="http://tempuri.org/IService/GetNewSchoolInterestListForStudentResponse")]
        System.Threading.Tasks.Task<string> GetNewSchoolInterestListForStudentAsync(
                    string SchoolYear, 
                    string Type, 
                    string StudentNo, 
                    string CaseID, 
                    string AddressID, 
                    string GeoParam, 
                    string GradeParam, 
                    string DOBparam, 
                    string ProgramCodeList, 
                    string IsAWCParam, 
                    string IsBASParam, 
                    string SNCodeParam, 
                    string LepStatusParam, 
                    string ELDLevelParam, 
                    string SifeStatusParam, 
                    string FirstLangParam, 
                    string SiblingsList, 
                    string TierVersion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMySiblings", ReplyAction="http://tempuri.org/IService/GetMySiblingsResponse")]
        string GetMySiblings(string StudentNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetMySiblings", ReplyAction="http://tempuri.org/IService/GetMySiblingsResponse")]
        System.Threading.Tasks.Task<string> GetMySiblingsAsync(string StudentNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DetermineTransEligibilityByAddressID", ReplyAction="http://tempuri.org/IService/DetermineTransEligibilityByAddressIDResponse")]
        string DetermineTransEligibilityByAddressID(string SchoolYear, string AddressID, string Sch, string Grade, string SEICode, string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/DetermineTransEligibilityByAddressID", ReplyAction="http://tempuri.org/IService/DetermineTransEligibilityByAddressIDResponse")]
        System.Threading.Tasks.Task<string> DetermineTransEligibilityByAddressIDAsync(string SchoolYear, string AddressID, string Sch, string Grade, string SEICode, string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendClosestFacility", ReplyAction="http://tempuri.org/IService/SendClosestFacilityResponse")]
        string SendClosestFacility(string AddressID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/SendClosestFacility", ReplyAction="http://tempuri.org/IService/SendClosestFacilityResponse")]
        System.Threading.Tasks.Task<string> SendClosestFacilityAsync(string AddressID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : RegistrationAutoAssignment.Repositories.StudentSchoolChoices.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<RegistrationAutoAssignment.Repositories.StudentSchoolChoices.IService>, RegistrationAutoAssignment.Repositories.StudentSchoolChoices.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public string GetSchoolSelections(string SchoolYear, string Grade, string Street, string StreetNumber, string ZipCode) {
            return base.Channel.GetSchoolSelections(SchoolYear, Grade, Street, StreetNumber, ZipCode);
        }
        
        public System.Threading.Tasks.Task<string> GetSchoolSelectionsAsync(string SchoolYear, string Grade, string Street, string StreetNumber, string ZipCode) {
            return base.Channel.GetSchoolSelectionsAsync(SchoolYear, Grade, Street, StreetNumber, ZipCode);
        }
        
        public string GetSchoolSelectionsForAspen(string schoolYear, string geo, string StreetNumber, string Street, string ZipCode, string Grade, string MyGroup, string Schools, string dob, string isAWC, string isBilingual, string BilCode, string SnCode, string isBAS, string isSifeProgram) {
            return base.Channel.GetSchoolSelectionsForAspen(schoolYear, geo, StreetNumber, Street, ZipCode, Grade, MyGroup, Schools, dob, isAWC, isBilingual, BilCode, SnCode, isBAS, isSifeProgram);
        }
        
        public System.Threading.Tasks.Task<string> GetSchoolSelectionsForAspenAsync(string schoolYear, string geo, string StreetNumber, string Street, string ZipCode, string Grade, string MyGroup, string Schools, string dob, string isAWC, string isBilingual, string BilCode, string SnCode, string isBAS, string isSifeProgram) {
            return base.Channel.GetSchoolSelectionsForAspenAsync(schoolYear, geo, StreetNumber, Street, ZipCode, Grade, MyGroup, Schools, dob, isAWC, isBilingual, BilCode, SnCode, isBAS, isSifeProgram);
        }
        
        public string GetGeoList(string Street, string StreetNumber, string ZipCode) {
            return base.Channel.GetGeoList(Street, StreetNumber, ZipCode);
        }
        
        public System.Threading.Tasks.Task<string> GetGeoListAsync(string Street, string StreetNumber, string ZipCode) {
            return base.Channel.GetGeoListAsync(Street, StreetNumber, ZipCode);
        }
        
        public string GetGeoListNew(string Street, string StreetNumber, string ZipCode) {
            return base.Channel.GetGeoListNew(Street, StreetNumber, ZipCode);
        }
        
        public System.Threading.Tasks.Task<string> GetGeoListNewAsync(string Street, string StreetNumber, string ZipCode) {
            return base.Channel.GetGeoListNewAsync(Street, StreetNumber, ZipCode);
        }
        
        public string GetAssignmentWalkEligibilityStatusByGeoCode(string GeoCode, string SchoolYear, string SchoolCode, string Grade) {
            return base.Channel.GetAssignmentWalkEligibilityStatusByGeoCode(GeoCode, SchoolYear, SchoolCode, Grade);
        }
        
        public System.Threading.Tasks.Task<string> GetAssignmentWalkEligibilityStatusByGeoCodeAsync(string GeoCode, string SchoolYear, string SchoolCode, string Grade) {
            return base.Channel.GetAssignmentWalkEligibilityStatusByGeoCodeAsync(GeoCode, SchoolYear, SchoolCode, Grade);
        }
        
        public string GetAssignmentWalkEligibilityStatusByAddress(string StreetNumber, string Street, string ZipCode, string SchoolYear, string SchoolCode, string Grade) {
            return base.Channel.GetAssignmentWalkEligibilityStatusByAddress(StreetNumber, Street, ZipCode, SchoolYear, SchoolCode, Grade);
        }
        
        public System.Threading.Tasks.Task<string> GetAssignmentWalkEligibilityStatusByAddressAsync(string StreetNumber, string Street, string ZipCode, string SchoolYear, string SchoolCode, string Grade) {
            return base.Channel.GetAssignmentWalkEligibilityStatusByAddressAsync(StreetNumber, Street, ZipCode, SchoolYear, SchoolCode, Grade);
        }
        
        public string GetSchoolSelectionsForStudents(string schoolYear, string GeoCode, string Grade, string dob, string isAWC, string isBAS, string LEPStatus, string ELDScore, string SifeLevel, string FirstLanguage, string SNCode, string AssignSchForGuarantee, string AssignGradeForGuarantee, string AsignProgramForGuarantee, string IncludeIntHigh) {
            return base.Channel.GetSchoolSelectionsForStudents(schoolYear, GeoCode, Grade, dob, isAWC, isBAS, LEPStatus, ELDScore, SifeLevel, FirstLanguage, SNCode, AssignSchForGuarantee, AssignGradeForGuarantee, AsignProgramForGuarantee, IncludeIntHigh);
        }
        
        public System.Threading.Tasks.Task<string> GetSchoolSelectionsForStudentsAsync(string schoolYear, string GeoCode, string Grade, string dob, string isAWC, string isBAS, string LEPStatus, string ELDScore, string SifeLevel, string FirstLanguage, string SNCode, string AssignSchForGuarantee, string AssignGradeForGuarantee, string AsignProgramForGuarantee, string IncludeIntHigh) {
            return base.Channel.GetSchoolSelectionsForStudentsAsync(schoolYear, GeoCode, Grade, dob, isAWC, isBAS, LEPStatus, ELDScore, SifeLevel, FirstLanguage, SNCode, AssignSchForGuarantee, AssignGradeForGuarantee, AsignProgramForGuarantee, IncludeIntHigh);
        }
        
        public string GetSchoolSelectionsForStudent(string schoolYear, string GeoCode, string Grade, string dob, string isAWC, string isBAS, string LEPStatus, string ELDScore, string SifeLevel, string FirstLanguage, string SNCode, string AssignSchForGuarantee, string AssignGradeForGuarantee, string AsignProgramForGuarantee, string IncludeIntHigh) {
            return base.Channel.GetSchoolSelectionsForStudent(schoolYear, GeoCode, Grade, dob, isAWC, isBAS, LEPStatus, ELDScore, SifeLevel, FirstLanguage, SNCode, AssignSchForGuarantee, AssignGradeForGuarantee, AsignProgramForGuarantee, IncludeIntHigh);
        }
        
        public System.Threading.Tasks.Task<string> GetSchoolSelectionsForStudentAsync(string schoolYear, string GeoCode, string Grade, string dob, string isAWC, string isBAS, string LEPStatus, string ELDScore, string SifeLevel, string FirstLanguage, string SNCode, string AssignSchForGuarantee, string AssignGradeForGuarantee, string AsignProgramForGuarantee, string IncludeIntHigh) {
            return base.Channel.GetSchoolSelectionsForStudentAsync(schoolYear, GeoCode, Grade, dob, isAWC, isBAS, LEPStatus, ELDScore, SifeLevel, FirstLanguage, SNCode, AssignSchForGuarantee, AssignGradeForGuarantee, AsignProgramForGuarantee, IncludeIntHigh);
        }
        
        public string GetProgramCodeFromEnrollmentFields(string SchoolYear, string School, string grade, string SeiCode, string SNCode, string isAWC, string Voced, string isExtendedDay, string isTwoWay, string isSpedIntegrated, string isMontessori, string isSife, string isHybrid) {
            return base.Channel.GetProgramCodeFromEnrollmentFields(SchoolYear, School, grade, SeiCode, SNCode, isAWC, Voced, isExtendedDay, isTwoWay, isSpedIntegrated, isMontessori, isSife, isHybrid);
        }
        
        public System.Threading.Tasks.Task<string> GetProgramCodeFromEnrollmentFieldsAsync(string SchoolYear, string School, string grade, string SeiCode, string SNCode, string isAWC, string Voced, string isExtendedDay, string isTwoWay, string isSpedIntegrated, string isMontessori, string isSife, string isHybrid) {
            return base.Channel.GetProgramCodeFromEnrollmentFieldsAsync(SchoolYear, School, grade, SeiCode, SNCode, isAWC, Voced, isExtendedDay, isTwoWay, isSpedIntegrated, isMontessori, isSife, isHybrid);
        }
        
        public string GetNewSchoolChoicesForStudent(
                    string SchoolYear, 
                    string Type, 
                    string StudentNo, 
                    string CaseID, 
                    string AddressID, 
                    string GeoParam, 
                    string GradeParam, 
                    string DOBparam, 
                    string ProgramCodeList, 
                    string IsAWCParam, 
                    string IsBASParam, 
                    string SNCodeParam, 
                    string LepStatusParam, 
                    string ELDLevelParam, 
                    string SifeStatusParam, 
                    string FirstLangParam, 
                    string SiblingsList, 
                    string TierVersion) {
            return base.Channel.GetNewSchoolChoicesForStudent(SchoolYear, Type, StudentNo, CaseID, AddressID, GeoParam, GradeParam, DOBparam, ProgramCodeList, IsAWCParam, IsBASParam, SNCodeParam, LepStatusParam, ELDLevelParam, SifeStatusParam, FirstLangParam, SiblingsList, TierVersion);
        }
        
        public System.Threading.Tasks.Task<string> GetNewSchoolChoicesForStudentAsync(
                    string SchoolYear, 
                    string Type, 
                    string StudentNo, 
                    string CaseID, 
                    string AddressID, 
                    string GeoParam, 
                    string GradeParam, 
                    string DOBparam, 
                    string ProgramCodeList, 
                    string IsAWCParam, 
                    string IsBASParam, 
                    string SNCodeParam, 
                    string LepStatusParam, 
                    string ELDLevelParam, 
                    string SifeStatusParam, 
                    string FirstLangParam, 
                    string SiblingsList, 
                    string TierVersion) {
            return base.Channel.GetNewSchoolChoicesForStudentAsync(SchoolYear, Type, StudentNo, CaseID, AddressID, GeoParam, GradeParam, DOBparam, ProgramCodeList, IsAWCParam, IsBASParam, SNCodeParam, LepStatusParam, ELDLevelParam, SifeStatusParam, FirstLangParam, SiblingsList, TierVersion);
        }
        
        public string GetNewSchoolInterestListForStudent(
                    string SchoolYear, 
                    string Type, 
                    string StudentNo, 
                    string CaseID, 
                    string AddressID, 
                    string GeoParam, 
                    string GradeParam, 
                    string DOBparam, 
                    string ProgramCodeList, 
                    string IsAWCParam, 
                    string IsBASParam, 
                    string SNCodeParam, 
                    string LepStatusParam, 
                    string ELDLevelParam, 
                    string SifeStatusParam, 
                    string FirstLangParam, 
                    string SiblingsList, 
                    string TierVersion) {
            return base.Channel.GetNewSchoolInterestListForStudent(SchoolYear, Type, StudentNo, CaseID, AddressID, GeoParam, GradeParam, DOBparam, ProgramCodeList, IsAWCParam, IsBASParam, SNCodeParam, LepStatusParam, ELDLevelParam, SifeStatusParam, FirstLangParam, SiblingsList, TierVersion);
        }
        
        public System.Threading.Tasks.Task<string> GetNewSchoolInterestListForStudentAsync(
                    string SchoolYear, 
                    string Type, 
                    string StudentNo, 
                    string CaseID, 
                    string AddressID, 
                    string GeoParam, 
                    string GradeParam, 
                    string DOBparam, 
                    string ProgramCodeList, 
                    string IsAWCParam, 
                    string IsBASParam, 
                    string SNCodeParam, 
                    string LepStatusParam, 
                    string ELDLevelParam, 
                    string SifeStatusParam, 
                    string FirstLangParam, 
                    string SiblingsList, 
                    string TierVersion) {
            return base.Channel.GetNewSchoolInterestListForStudentAsync(SchoolYear, Type, StudentNo, CaseID, AddressID, GeoParam, GradeParam, DOBparam, ProgramCodeList, IsAWCParam, IsBASParam, SNCodeParam, LepStatusParam, ELDLevelParam, SifeStatusParam, FirstLangParam, SiblingsList, TierVersion);
        }
        
        public string GetMySiblings(string StudentNumber) {
            return base.Channel.GetMySiblings(StudentNumber);
        }
        
        public System.Threading.Tasks.Task<string> GetMySiblingsAsync(string StudentNumber) {
            return base.Channel.GetMySiblingsAsync(StudentNumber);
        }
        
        public string DetermineTransEligibilityByAddressID(string SchoolYear, string AddressID, string Sch, string Grade, string SEICode, string ZipCode) {
            return base.Channel.DetermineTransEligibilityByAddressID(SchoolYear, AddressID, Sch, Grade, SEICode, ZipCode);
        }
        
        public System.Threading.Tasks.Task<string> DetermineTransEligibilityByAddressIDAsync(string SchoolYear, string AddressID, string Sch, string Grade, string SEICode, string ZipCode) {
            return base.Channel.DetermineTransEligibilityByAddressIDAsync(SchoolYear, AddressID, Sch, Grade, SEICode, ZipCode);
        }
        
        public string SendClosestFacility(string AddressID) {
            return base.Channel.SendClosestFacility(AddressID);
        }
        
        public System.Threading.Tasks.Task<string> SendClosestFacilityAsync(string AddressID) {
            return base.Channel.SendClosestFacilityAsync(AddressID);
        }
    }
}
