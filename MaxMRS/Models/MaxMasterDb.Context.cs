﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MaxMasterDbEntities : DbContext
    {
        public MaxMasterDbEntities()
            : base("name=MaxMasterDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ApprovedInvoice> ApprovedInvoices { get; set; }
        public virtual DbSet<ApprovedInvoiceService> ApprovedInvoiceServices { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<ClientEmployee> ClientEmployees { get; set; }
        public virtual DbSet<ClientErrorLog> ClientErrorLogs { get; set; }
        public virtual DbSet<ClientLocation> ClientLocations { get; set; }
        public virtual DbSet<ClientReceivable> ClientReceivables { get; set; }
        public virtual DbSet<ClientReceivableService> ClientReceivableServices { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<ClientVertical> ClientVerticals { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<DefaultAllocation> DefaultAllocations { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<DoctorGroup> DoctorGroups { get; set; }
        public virtual DbSet<Doctor> Doctors { get; set; }
        public virtual DbSet<DoctorVoiceGrade> DoctorVoiceGrades { get; set; }
        public virtual DbSet<Document> Documents { get; set; }
        public virtual DbSet<EmployeePaymentRecord> EmployeePaymentRecords { get; set; }
        public virtual DbSet<EmployeePayscale> EmployeePayscales { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLogs { get; set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<InvoiceService> InvoiceServices { get; set; }
        public virtual DbSet<LeaveRecord> LeaveRecords { get; set; }
        public virtual DbSet<Leaf> Leaves { get; set; }
        public virtual DbSet<Specialty> Specialties { get; set; }
        public virtual DbSet<State> States { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TimeZone> TimeZones { get; set; }
        public virtual DbSet<VoiceGradePricing> VoiceGradePricings { get; set; }
    
        public virtual ObjectResult<ClientMasterReport_Result> ClientMasterReport(Nullable<int> clientId, Nullable<System.DateTime> fromdate, Nullable<System.DateTime> todate, Nullable<int> pageNumber, Nullable<int> recordsPerPage, string sortCol, string sortDir)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            var todateParameter = todate.HasValue ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(System.DateTime));
    
            var pageNumberParameter = pageNumber.HasValue ?
                new ObjectParameter("PageNumber", pageNumber) :
                new ObjectParameter("PageNumber", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var sortColParameter = sortCol != null ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(string));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ClientMasterReport_Result>("ClientMasterReport", clientIdParameter, fromdateParameter, todateParameter, pageNumberParameter, recordsPerPageParameter, sortColParameter, sortDirParameter);
        }
    
        public virtual ObjectResult<ClientPayments_Result> ClientPayments(Nullable<int> client_Id)
        {
            var client_IdParameter = client_Id.HasValue ?
                new ObjectParameter("Client_Id", client_Id) :
                new ObjectParameter("Client_Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ClientPayments_Result>("ClientPayments", client_IdParameter);
        }
    
        public virtual ObjectResult<DoctorDetailsGet_Result> DoctorDetailsGet(string idigitalAuthorId, string name, string client, string email, string phoneNumber, string jobLevel, string voiceGrade, Nullable<int> pageNumber, Nullable<int> recordsPerPage, string sortCol, string sortDir)
        {
            var idigitalAuthorIdParameter = idigitalAuthorId != null ?
                new ObjectParameter("IdigitalAuthorId", idigitalAuthorId) :
                new ObjectParameter("IdigitalAuthorId", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var clientParameter = client != null ?
                new ObjectParameter("Client", client) :
                new ObjectParameter("Client", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneNumberParameter = phoneNumber != null ?
                new ObjectParameter("PhoneNumber", phoneNumber) :
                new ObjectParameter("PhoneNumber", typeof(string));
    
            var jobLevelParameter = jobLevel != null ?
                new ObjectParameter("JobLevel", jobLevel) :
                new ObjectParameter("JobLevel", typeof(string));
    
            var voiceGradeParameter = voiceGrade != null ?
                new ObjectParameter("VoiceGrade", voiceGrade) :
                new ObjectParameter("VoiceGrade", typeof(string));
    
            var pageNumberParameter = pageNumber.HasValue ?
                new ObjectParameter("PageNumber", pageNumber) :
                new ObjectParameter("PageNumber", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var sortColParameter = sortCol != null ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(string));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<DoctorDetailsGet_Result>("DoctorDetailsGet", idigitalAuthorIdParameter, nameParameter, clientParameter, emailParameter, phoneNumberParameter, jobLevelParameter, voiceGradeParameter, pageNumberParameter, recordsPerPageParameter, sortColParameter, sortDirParameter);
        }
    
        public virtual ObjectResult<GetClientEmployees_Result> GetClientEmployees(Nullable<int> clientId, string firstName, string lastName, string email, string primaryPhone, string department, Nullable<int> pageNumber, Nullable<int> recordsPerPage, string sortCol, string sortDir)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var primaryPhoneParameter = primaryPhone != null ?
                new ObjectParameter("PrimaryPhone", primaryPhone) :
                new ObjectParameter("PrimaryPhone", typeof(string));
    
            var departmentParameter = department != null ?
                new ObjectParameter("Department", department) :
                new ObjectParameter("Department", typeof(string));
    
            var pageNumberParameter = pageNumber.HasValue ?
                new ObjectParameter("PageNumber", pageNumber) :
                new ObjectParameter("PageNumber", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var sortColParameter = sortCol != null ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(string));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetClientEmployees_Result>("GetClientEmployees", clientIdParameter, firstNameParameter, lastNameParameter, emailParameter, primaryPhoneParameter, departmentParameter, pageNumberParameter, recordsPerPageParameter, sortColParameter, sortDirParameter);
        }
    
        public virtual ObjectResult<GetClients_Result> GetClients(string clientName, string phone, string email, string clientType, string fax, Nullable<int> pageNumber, Nullable<int> recordsPerPage, string sortCol, string sortDir)
        {
            var clientNameParameter = clientName != null ?
                new ObjectParameter("ClientName", clientName) :
                new ObjectParameter("ClientName", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var clientTypeParameter = clientType != null ?
                new ObjectParameter("ClientType", clientType) :
                new ObjectParameter("ClientType", typeof(string));
    
            var faxParameter = fax != null ?
                new ObjectParameter("Fax", fax) :
                new ObjectParameter("Fax", typeof(string));
    
            var pageNumberParameter = pageNumber.HasValue ?
                new ObjectParameter("PageNumber", pageNumber) :
                new ObjectParameter("PageNumber", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var sortColParameter = sortCol != null ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(string));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetClients_Result>("GetClients", clientNameParameter, phoneParameter, emailParameter, clientTypeParameter, faxParameter, pageNumberParameter, recordsPerPageParameter, sortColParameter, sortDirParameter);
        }
    
        public virtual ObjectResult<GetDefaultAllocations_Result> GetDefaultAllocations(Nullable<int> clientId, Nullable<int> doctorId, Nullable<int> employeeId, string jobLevel, Nullable<int> pageNumber, Nullable<int> recordsPerPage, string sortCol, string sortDir)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("DoctorId", doctorId) :
                new ObjectParameter("DoctorId", typeof(int));
    
            var employeeIdParameter = employeeId.HasValue ?
                new ObjectParameter("EmployeeId", employeeId) :
                new ObjectParameter("EmployeeId", typeof(int));
    
            var jobLevelParameter = jobLevel != null ?
                new ObjectParameter("JobLevel", jobLevel) :
                new ObjectParameter("JobLevel", typeof(string));
    
            var pageNumberParameter = pageNumber.HasValue ?
                new ObjectParameter("PageNumber", pageNumber) :
                new ObjectParameter("PageNumber", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var sortColParameter = sortCol != null ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(string));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDefaultAllocations_Result>("GetDefaultAllocations", clientIdParameter, doctorIdParameter, employeeIdParameter, jobLevelParameter, pageNumberParameter, recordsPerPageParameter, sortColParameter, sortDirParameter);
        }
    
        public virtual ObjectResult<GetEmployeeDocuments_Result> GetEmployeeDocuments(Nullable<int> empId, string category, Nullable<System.DateTime> documentDate, Nullable<System.DateTime> uploadDate, string notes, string keyWords, Nullable<int> pageNumber, Nullable<int> recordsPerPage, string sortCol, string sortDir)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            var categoryParameter = category != null ?
                new ObjectParameter("Category", category) :
                new ObjectParameter("Category", typeof(string));
    
            var documentDateParameter = documentDate.HasValue ?
                new ObjectParameter("DocumentDate", documentDate) :
                new ObjectParameter("DocumentDate", typeof(System.DateTime));
    
            var uploadDateParameter = uploadDate.HasValue ?
                new ObjectParameter("UploadDate", uploadDate) :
                new ObjectParameter("UploadDate", typeof(System.DateTime));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            var keyWordsParameter = keyWords != null ?
                new ObjectParameter("KeyWords", keyWords) :
                new ObjectParameter("KeyWords", typeof(string));
    
            var pageNumberParameter = pageNumber.HasValue ?
                new ObjectParameter("PageNumber", pageNumber) :
                new ObjectParameter("PageNumber", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var sortColParameter = sortCol != null ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(string));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployeeDocuments_Result>("GetEmployeeDocuments", empIdParameter, categoryParameter, documentDateParameter, uploadDateParameter, notesParameter, keyWordsParameter, pageNumberParameter, recordsPerPageParameter, sortColParameter, sortDirParameter);
        }
    
        public virtual ObjectResult<GetEmployees_Result> GetEmployees(string empNumber, string empName, string email, string primaryPhone, string department, string designation, Nullable<int> pageNumber, Nullable<int> recordsPerPage, string sortCol, string sortDir)
        {
            var empNumberParameter = empNumber != null ?
                new ObjectParameter("EmpNumber", empNumber) :
                new ObjectParameter("EmpNumber", typeof(string));
    
            var empNameParameter = empName != null ?
                new ObjectParameter("EmpName", empName) :
                new ObjectParameter("EmpName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var primaryPhoneParameter = primaryPhone != null ?
                new ObjectParameter("PrimaryPhone", primaryPhone) :
                new ObjectParameter("PrimaryPhone", typeof(string));
    
            var departmentParameter = department != null ?
                new ObjectParameter("Department", department) :
                new ObjectParameter("Department", typeof(string));
    
            var designationParameter = designation != null ?
                new ObjectParameter("Designation", designation) :
                new ObjectParameter("Designation", typeof(string));
    
            var pageNumberParameter = pageNumber.HasValue ?
                new ObjectParameter("PageNumber", pageNumber) :
                new ObjectParameter("PageNumber", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var sortColParameter = sortCol != null ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(string));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetEmployees_Result>("GetEmployees", empNumberParameter, empNameParameter, emailParameter, primaryPhoneParameter, departmentParameter, designationParameter, pageNumberParameter, recordsPerPageParameter, sortColParameter, sortDirParameter);
        }
    
        public virtual ObjectResult<Max_DoctorLineCount_Result> Max_DoctorLineCount(Nullable<int> clientId, Nullable<System.DateTime> fromDate, Nullable<System.DateTime> toDate)
        {
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var fromDateParameter = fromDate.HasValue ?
                new ObjectParameter("fromDate", fromDate) :
                new ObjectParameter("fromDate", typeof(System.DateTime));
    
            var toDateParameter = toDate.HasValue ?
                new ObjectParameter("toDate", toDate) :
                new ObjectParameter("toDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Max_DoctorLineCount_Result>("Max_DoctorLineCount", clientIdParameter, fromDateParameter, toDateParameter);
        }
    
        public virtual int MaxClient_Report(Nullable<int> client_Id, Nullable<System.DateTime> fromdate, Nullable<System.DateTime> todate)
        {
            var client_IdParameter = client_Id.HasValue ?
                new ObjectParameter("Client_Id", client_Id) :
                new ObjectParameter("Client_Id", typeof(int));
    
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            var todateParameter = todate.HasValue ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MaxClient_Report", client_IdParameter, fromdateParameter, todateParameter);
        }
    
        public virtual ObjectResult<MaxClientDueDetails_Result> MaxClientDueDetails(Nullable<int> client_Id, string invoiceId)
        {
            var client_IdParameter = client_Id.HasValue ?
                new ObjectParameter("Client_Id", client_Id) :
                new ObjectParameter("Client_Id", typeof(int));
    
            var invoiceIdParameter = invoiceId != null ?
                new ObjectParameter("InvoiceId", invoiceId) :
                new ObjectParameter("InvoiceId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MaxClientDueDetails_Result>("MaxClientDueDetails", client_IdParameter, invoiceIdParameter);
        }
    
        public virtual int MaxClientService_Details(Nullable<int> client_Id, Nullable<System.DateTime> fromdate, Nullable<System.DateTime> todate)
        {
            var client_IdParameter = client_Id.HasValue ?
                new ObjectParameter("Client_Id", client_Id) :
                new ObjectParameter("Client_Id", typeof(int));
    
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            var todateParameter = todate.HasValue ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("MaxClientService_Details", client_IdParameter, fromdateParameter, todateParameter);
        }
    
        public virtual ObjectResult<MaxEmpReport_Result> MaxEmpReport(Nullable<int> empId, Nullable<int> clientId, Nullable<int> doctorId, string jobWorkLevel, Nullable<System.DateTime> fromdate, Nullable<System.DateTime> todate, Nullable<int> pageNumber, Nullable<int> recordsPerPage, string sortCol, string sortDir)
        {
            var empIdParameter = empId.HasValue ?
                new ObjectParameter("EmpId", empId) :
                new ObjectParameter("EmpId", typeof(int));
    
            var clientIdParameter = clientId.HasValue ?
                new ObjectParameter("ClientId", clientId) :
                new ObjectParameter("ClientId", typeof(int));
    
            var doctorIdParameter = doctorId.HasValue ?
                new ObjectParameter("DoctorId", doctorId) :
                new ObjectParameter("DoctorId", typeof(int));
    
            var jobWorkLevelParameter = jobWorkLevel != null ?
                new ObjectParameter("JobWorkLevel", jobWorkLevel) :
                new ObjectParameter("JobWorkLevel", typeof(string));
    
            var fromdateParameter = fromdate.HasValue ?
                new ObjectParameter("fromdate", fromdate) :
                new ObjectParameter("fromdate", typeof(System.DateTime));
    
            var todateParameter = todate.HasValue ?
                new ObjectParameter("todate", todate) :
                new ObjectParameter("todate", typeof(System.DateTime));
    
            var pageNumberParameter = pageNumber.HasValue ?
                new ObjectParameter("PageNumber", pageNumber) :
                new ObjectParameter("PageNumber", typeof(int));
    
            var recordsPerPageParameter = recordsPerPage.HasValue ?
                new ObjectParameter("RecordsPerPage", recordsPerPage) :
                new ObjectParameter("RecordsPerPage", typeof(int));
    
            var sortColParameter = sortCol != null ?
                new ObjectParameter("SortCol", sortCol) :
                new ObjectParameter("SortCol", typeof(string));
    
            var sortDirParameter = sortDir != null ?
                new ObjectParameter("SortDir", sortDir) :
                new ObjectParameter("SortDir", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MaxEmpReport_Result>("MaxEmpReport", empIdParameter, clientIdParameter, doctorIdParameter, jobWorkLevelParameter, fromdateParameter, todateParameter, pageNumberParameter, recordsPerPageParameter, sortColParameter, sortDirParameter);
        }
    
        public virtual ObjectResult<ProcedureName_Result> ProcedureName(Nullable<int> p1, Nullable<int> p2)
        {
            var p1Parameter = p1.HasValue ?
                new ObjectParameter("p1", p1) :
                new ObjectParameter("p1", typeof(int));
    
            var p2Parameter = p2.HasValue ?
                new ObjectParameter("p2", p2) :
                new ObjectParameter("p2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ProcedureName_Result>("ProcedureName", p1Parameter, p2Parameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
