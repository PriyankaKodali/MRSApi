using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaxMRS.ViewModels
{

    public class ClientEmployeeViewModel

    {
        public int Id { get; set; }
        public DateTime? JobDate { get; set; }
        public string JobNumber { get; set; }
        public string DoctorName { get; set; }
        public int? TotalPages { get; set; }
        public int? DoctorId { get; set; }
        public string Status { get; set; }
        public string FileName { get; set; }
        public List<ClientEmployeeViewModel> EmployeeUploads { get; set; }

    }   

    public class JobsViewModel
    {
        public int JobId { get; set; }
        public string JobNumber { get; set; }
        public string JobDate { get; set; }
        public string JobLevel { get; set; }
        public int ClientId { get; set; }
        public int MTId { get; set; }
        public string MT { get; set; }
        public int AQAId { get; set; }
        public string AQA { get; set; }
        public int QAId { get; set; }
        public string QA { get; set; }
        public string Status { get; set; }
        public int TAT { get; set; }
        public int TotalPages { get; set; }
        public DateTime? UT { get; set; }
        public DateTime? DT { get; set; }
        public bool IsLastSplit { get; set; }
    }

    public class SplitJobsViewModel
    {
        public string JobNumber { get; set; }
        public int MTId { get; set; }
        public string MT { get; set; }
        public int AQAId { get; set; }
        public string AQA { get; set; }
        public int QAId { get; set; }
        public string QA { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
    }

    public class UploadsModel
    {
        public string JobNumber { get; set; }
        public string ClientFilePath { get; set; }
        public string FileName { get; set; }
        public string Status { get; set; }
        public DateTime? UploadedDate { get; set; }
        public string DoctorName { get; set; }
        public int? TotalPages { get; set; }
    }
    
}