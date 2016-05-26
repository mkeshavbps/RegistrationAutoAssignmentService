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
    
    public partial class AddressFile
    {
        public string streetno { get; set; }
        public string street { get; set; }
        public string zip { get; set; }
        public string geo { get; set; }
        public Nullable<double> CityOfBostonX { get; set; }
        public Nullable<double> CityOfBostonY { get; set; }
        public Nullable<double> score { get; set; }
        public string geoFromCOB { get; set; }
        public string ELLClusterFromCOB { get; set; }
        public Nullable<bool> isLikelyInvalid { get; set; }
        public string COBLocName { get; set; }
        public string COBSide { get; set; }
        public string COBStreetNum { get; set; }
        public string COBStreetName { get; set; }
        public string COBStreetSuffix { get; set; }
        public string COBStreetSufDir { get; set; }
        public string COBCity { get; set; }
        public string COBZip { get; set; }
        public string COBAddrType { get; set; }
        public string COBMatchAddress { get; set; }
        public int AddressID { get; set; }
        public Nullable<System.DateTime> processedDate { get; set; }
        public string COBToAddr { get; set; }
        public string COBFromAddr { get; set; }
        public string StreetAlias { get; set; }
        public Nullable<double> Longitude { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> GoogleX { get; set; }
        public Nullable<double> GoogleY { get; set; }
        public Nullable<double> GoogleLongitude { get; set; }
        public Nullable<double> GoogleLatitude { get; set; }
        public Nullable<System.DateTime> GoogleProcesedDate { get; set; }
        public Nullable<int> GoogleProcessPriority { get; set; }
        public string GoogleStreetNumber { get; set; }
        public string GoogleStreetName { get; set; }
        public string GoogleCitySection { get; set; }
        public string GoogleLocationType { get; set; }
        public Nullable<bool> GooglePartialMatch { get; set; }
        public Nullable<int> VersatransX { get; set; }
        public Nullable<int> VersatransY { get; set; }
        public Nullable<double> VersatransLongitude { get; set; }
        public Nullable<double> VersatransLatitude { get; set; }
        public Nullable<bool> IsPriorityAdjustedfromVT { get; set; }
        public bool processedClosestFacility { get; set; }
        public Nullable<int> TransportationProcessPriority { get; set; }
        public Nullable<bool> IsSetFromGoogle { get; set; }
        public Nullable<bool> IsSetFromVersatrans { get; set; }
        public Nullable<double> CityOfBostonXOrig { get; set; }
        public Nullable<double> CityOfBostonYOrig { get; set; }
        public Nullable<double> CityOfBostonLongitude { get; set; }
        public Nullable<double> CityOfBostonLatitude { get; set; }
    }
}
