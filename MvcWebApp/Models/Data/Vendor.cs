//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MvcWebApp.Models.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vendor
    {
        public int ID { get; set; }
        public int ConferenceID { get; set; }
        public string UKey { get; set; }
        public string Name { get; set; }
        public string Booth { get; set; }
        public string Description { get; set; }
        public string URL { get; set; }
        public string LogoURL { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime ModifiedOn { get; set; }
        public string Twitter { get; set; }
        public string ImageURL { get; set; }
        public byte[] Timestamp { get; set; }
    
        public virtual Conference Conference { get; set; }
    }
}