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
    
    public partial class GetEmployees_Result
    {
        public Nullable<long> RowNum { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PrimaryPhone { get; set; }
        public string Email { get; set; }
        public int Designation_Id { get; set; }
        public string Designation { get; set; }
        public int Department_Id { get; set; }
        public string Department { get; set; }
        public string EmpNum { get; set; }
        public Nullable<int> Manager { get; set; }
        public Nullable<int> TotalCount { get; set; }
    }
}