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
    
    public partial class EmployeePaymentRecord
    {
        public int Id { get; set; }
        public System.DateTime Date { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public short Period { get; set; }
        public int Basic { get; set; }
        public int HRA { get; set; }
        public int Conveyance { get; set; }
        public int MedicalAllowance { get; set; }
        public int SpecialAllowance { get; set; }
        public int ProfessionalTax { get; set; }
        public int TDS { get; set; }
        public int Insurance { get; set; }
        public int PF { get; set; }
        public int ESI { get; set; }
        public int CalculatedAmount { get; set; }
        public int Advance { get; set; }
        public int Reimbursement { get; set; }
        public int LossOfPay { get; set; }
        public int Incentive { get; set; }
        public int Penalty { get; set; }
        public int OtherDeductions { get; set; }
        public int NetAmount { get; set; }
        public string Notes { get; set; }
        public int Employee_Id { get; set; }
        public string PaymentType { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
