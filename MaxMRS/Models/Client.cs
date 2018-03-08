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
    
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            this.ApprovedInvoices = new HashSet<ApprovedInvoice>();
            this.ApprovedInvoiceServices = new HashSet<ApprovedInvoiceService>();
            this.ClientEmployees = new HashSet<ClientEmployee>();
            this.ClientLocations = new HashSet<ClientLocation>();
            this.ClientReceivables = new HashSet<ClientReceivable>();
            this.DefaultAllocations = new HashSet<DefaultAllocation>();
            this.Doctors = new HashSet<Doctor>();
            this.InvoiceServices = new HashSet<InvoiceService>();
            this.ClientVerticals = new HashSet<ClientVertical>();
        }
    
        public int Id { get; set; }
        public string ClientType { get; set; }
        public string Name { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string EncrytionKey { get; set; }
        public Nullable<decimal> PaymentAmount { get; set; }
        public Nullable<int> Vendor_Id { get; set; }
        public string ShortName { get; set; }
        public string FileTypes { get; set; }
        public string Currency { get; set; }
        public Nullable<int> NumberOfCharactersPerLine { get; set; }
        public string PaymentType { get; set; }
        public Nullable<int> PercentPerUnit { get; set; }
        public bool Active { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApprovedInvoice> ApprovedInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApprovedInvoiceService> ApprovedInvoiceServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientEmployee> ClientEmployees { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientLocation> ClientLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientReceivable> ClientReceivables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefaultAllocation> DefaultAllocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Doctor> Doctors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceService> InvoiceServices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientVertical> ClientVerticals { get; set; }
    }
}
