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
    
    public partial class ClientPayments_Result
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public Nullable<decimal> DueAmount { get; set; }
        public Nullable<System.DateTime> InvoiceCreatedDate { get; set; }
        public string InvoiceId { get; set; }
        public string InvoiceMonth { get; set; }
        public int InvoiceYear { get; set; }
    }
}