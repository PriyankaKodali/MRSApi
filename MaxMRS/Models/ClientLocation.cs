//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MaxMRS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientLocation
    {
        public int Id { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Landmark { get; set; }
        public string ZIP { get; set; }
        public int City_Id { get; set; }
        public int Country_Id { get; set; }
        public int State_Id { get; set; }
        public int Client_Id { get; set; }
        public Nullable<bool> IsInvoiceAddress { get; set; }
        public Nullable<int> TimeZone_Id { get; set; }
    
        public virtual City City { get; set; }
        public virtual Client Client { get; set; }
        public virtual Country Country { get; set; }
        public virtual State State { get; set; }
        public virtual TimeZone TimeZone { get; set; }
    }
}