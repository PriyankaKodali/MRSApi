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
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.ApprovedInvoices = new HashSet<ApprovedInvoice>();
            this.ApprovedInvoices1 = new HashSet<ApprovedInvoice>();
            this.DefaultAllocations = new HashSet<DefaultAllocation>();
            this.Documents = new HashSet<Document>();
            this.EmployeePaymentRecords = new HashSet<EmployeePaymentRecord>();
            this.EmployeePayscales = new HashSet<EmployeePayscale>();
            this.Employees1 = new HashSet<Employee>();
            this.Employees11 = new HashSet<Employee>();
            this.Invoices = new HashSet<Invoice>();
            this.Invoices1 = new HashSet<Invoice>();
            this.LeaveRecords = new HashSet<LeaveRecord>();
            this.LeaveRecords1 = new HashSet<LeaveRecord>();
            this.LeaveRecords2 = new HashSet<LeaveRecord>();
            this.DoctorGroups = new HashSet<DoctorGroup>();
            this.Specialties = new HashSet<Specialty>();
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string PrimaryPhone { get; set; }
        public string SecondaryPhone { get; set; }
        public string Email { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string ZIP { get; set; }
        public string PhotoURL { get; set; }
        public string EmploymentType { get; set; }
        public System.DateTime DOB { get; set; }
        public System.DateTime DOJ { get; set; }
        public Nullable<System.DateTime> DOR { get; set; }
        public byte ProvisionalPeriod { get; set; }
        public bool Active { get; set; }
        public string PAN { get; set; }
        public string Aadhar { get; set; }
        public string BloodGroup { get; set; }
        public Nullable<int> Manager_Id { get; set; }
        public string EmployeeNumber { get; set; }
        public int City_Id { get; set; }
        public int Country_Id { get; set; }
        public int Department_Id { get; set; }
        public int Designation_Id { get; set; }
        public int State_Id { get; set; }
        public System.DateTime LastUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string Role_Id { get; set; }
        public string Gender { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApprovedInvoice> ApprovedInvoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ApprovedInvoice> ApprovedInvoices1 { get; set; }
        public virtual AspNetRole AspNetRole { get; set; }
        public virtual City City { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefaultAllocation> DefaultAllocations { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document> Documents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeePaymentRecord> EmployeePaymentRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeePayscale> EmployeePayscales { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees1 { get; set; }
        public virtual Employee Employee1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Employee> Employees11 { get; set; }
        public virtual Employee Employee2 { get; set; }
        public virtual Leaf Leaf { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Invoice> Invoices1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveRecord> LeaveRecords { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveRecord> LeaveRecords1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LeaveRecord> LeaveRecords2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DoctorGroup> DoctorGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Specialty> Specialties { get; set; }
    }
}
