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
    
    public partial class LogGetAddressMatch
    {
        public int GetAddressMatchesID { get; set; }
        public Nullable<int> WebServiceCallID { get; set; }
        public string StreetNum { get; set; }
        public string Street { get; set; }
        public string SectionOfCity { get; set; }
        public string ZipCode { get; set; }
        public string Zone { get; set; }
        public string GeoCode { get; set; }
        public Nullable<int> X { get; set; }
        public Nullable<int> Y { get; set; }
        public Nullable<double> Latitude { get; set; }
        public Nullable<double> Logitude { get; set; }
        public string InputStreetNumber { get; set; }
        public string InputStreet { get; set; }
        public string InputZipCode { get; set; }
        public string InputAddressID { get; set; }
    }
}
