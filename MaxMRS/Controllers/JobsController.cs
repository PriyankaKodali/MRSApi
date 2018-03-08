using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Net;
using MaxMRS.ViewModels;
using MaxMRS.Models;
using Microsoft.AspNet.Identity;
using System.IO;
using System.Configuration;
using Microsoft.Office.Interop.Word;

namespace MaxMRS.Controllers
{


    public class JobsController : ApiController
    {

        private static Random random = new Random();

        private static string RandomString(int length)
        {
            Random generator = new Random();
            var r = generator.Next(10000, 100000000).ToString();
            gotoRandom:
            using (MaxMRSEntities db = new MaxMRSEntities())
            {
                var jobNum = r;
                var exists = db.Jobs.Where(x => x.JobNumber == jobNum).FirstOrDefault();
                if(exists!=null)
                {
                    goto gotoRandom;
                }
            }
             return r;
        }


        #region "   Add Jobs from Client Employee  "
        [HttpPost]
        public IHttpActionResult AddFilesFromClientEmp()
        {
            // get the list of uploaded files from client employee
            var form = HttpContext.Current.Request.Form;
           
            var doctor_Id = form.Get("Doctor_Id");
            var userName = form.Get("UserName");
            var uploadeFiles = new List<HttpPostedFile>();

            var files = HttpContext.Current.Request.Files;
            var count = files.Count;

            try
            {
                using (MaxMRSEntities db = new MaxMRSEntities())
                {
                    Job job = new Job();
                  
                    using (MaxMasterDbEntities dbMaster = new MaxMasterDbEntities())
                    {
                        var clientId = dbMaster.ClientEmployees.Where(x => x.Email == userName).Select(x => x.Client_Id).FirstOrDefault();
                        var user = dbMaster.AspNetUsers.Where(x => x.Email == userName).FirstOrDefault();
                        var uploadedFiles = new List<HttpPostedFile>();
                        for (int i = 0; i < files.Count; i++)
                        {
                            uploadedFiles.Add(files[i]);
                        }

                        //for(int i=0; i < uploadedFiles.Count; i++)
                        //{
                        foreach(var fi in uploadedFiles)
                        {
                            // var fi = files[i];
                            var fileDirecory = HttpContext.Current.Server.MapPath("~/ClientEmployeeUploads");
                            if (!Directory.Exists(fileDirecory))
                            {
                                Directory.CreateDirectory(fileDirecory);
                            }

                            var fileName = fi.FileName;
                            var filepath = Path.Combine(fileDirecory, fileName);
                            
                            fi.SaveAs(filepath);

                            job.ClientFilePath = Path.Combine(ConfigurationManager.AppSettings["ApiUrl"], "ClientEmployeeUploads/", fileName);
                            job.JobNumber = clientId + "C" + RandomString(5);
                            job.Client_Id = clientId;
                            job.Arrival_Time = DateTime.Now;
                            job.UploadedBy = user.Id;

                            if(doctor_Id != null)
                            {
                                job.Doctor_Id = Convert.ToInt32(doctor_Id);
                                job.JobLevel = dbMaster.Doctors.Where(x => x.Id == job.Doctor_Id).Select(x => x.JobLevel).FirstOrDefault();
                            }

                            job.Status = "Pending";
                            
                            var application = new Application();

                            //var document = application.Documents.Open(@"C:\Users\Max Pc\Documents\Visual Studio 2015\Projects\MaxMRS\MaxMRS\ClientEmployeeUploads\636556001246522203_9924C26462493_MT.doc");

                            var fileType = Path.GetExtension(fileName);


                            var document = application.Documents.Open(fileDirecory + '/' + fileName);
                            var numberOfPages = document.ComputeStatistics(WdStatistic.wdStatisticPages, false);
                            application.Quit();

                            job.TotalPages = numberOfPages;

                            db.Jobs.Add(job);
                            db.SaveChanges();
                        }
                    }

                   return Ok();
                }
            }
            catch (Exception ex)
            {
                new Error().logAPIError(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), ex.StackTrace);
                return Content(HttpStatusCode.InternalServerError, "An error occured, please try agin later");
            }
        }
        #endregion

        #region " Get files uploaded by client Employee"
        [HttpGet]
        public IHttpActionResult GetUploadedFiles(string userName, DateTime? fromDate, DateTime? toDate, int? doctorId, string jobNumber, string status, int page, int count, string sortCol, string sortDir)
        {
            try
            {
                using (MaxMasterDbEntities dbMaster = new MaxMasterDbEntities())
                {
                    var user = dbMaster.AspNetUsers.Where(x => x.Email == userName).FirstOrDefault();
                    var userId = user.Id;
                    var clientId = dbMaster.ClientEmployees.Where(x => x.Email == userName).Select(x => x.Client_Id).FirstOrDefault();
                    var doctors = dbMaster.Doctors.Where(x => x.Client_Id == clientId).Select(x => new { value = x.Id, label = x.FirstName + " " + x.LastName }).OrderBy(x => x.label).ToList();

                    using (MaxMRSEntities db = new MaxMRSEntities())
                    {
                        int totalcount = 0;
                        var EmployeeUploads = db.GetClientUploadedJobs(userName, fromDate, toDate, doctorId, jobNumber, status, page, count, sortCol, sortDir).ToList();

                        if (EmployeeUploads.Count > 0)
                        {
                            totalcount = (int)EmployeeUploads.FirstOrDefault().TotalCount;
                        }

                        UploadsModel uploads = new UploadsModel();

                         List<UploadsModel> clientUploadsList = new List<UploadsModel>();

                        foreach(var uplds in EmployeeUploads)
                        {
                            
                            string[] filesplit= uplds.ClientFilePath.Split('/');
                            string fName = filesplit.Last();

                            clientUploadsList.Add(new UploadsModel()
                            {
                                DoctorName = uplds.DoctorName,
                                ClientFilePath = uplds.ClientFilePath,
                                Status = uplds.Status,
                                FileName = fName,
                                JobNumber = uplds.JobNumber,
                                UploadedDate = uplds.Arrival_Time,
                                TotalPages= uplds.TotalPages
                            });
                        }

                        return Content(HttpStatusCode.OK, new { doctors, totalcount, clientUploadsList });

                    }
                }
            }
            catch (Exception ex)
            {
                new Error().logAPIError(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), ex.StackTrace);
                return Content(HttpStatusCode.OK, "An error occured, please try agin later");
            }
        }
        #endregion

        #region " Get All Jobs for Coordinator"
        [HttpGet]
        public IHttpActionResult GetAllJobs(int? client_Id, DateTime? fromdate, DateTime? todate, int? MTId, int? AQAId, int? QAId, string sorCol, string SortDirec )
        {
            try
            {
                // get list of jobs through stored procedure and returns list to front end
                return Ok();
            }
            catch (Exception ex)
            {
                new Error().logAPIError(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), ex.StackTrace);
                return Content(HttpStatusCode.InternalServerError, "An error occured! please try again later");
            }
        }
        #endregion
        
        #region " Get employees list for job allocation"
        public IHttpActionResult GetEmployeesForAllocation()
        {
            try
            {
                // get list of employees for job allocation through query
                return Ok();
            }
            catch (Exception e)
            {
                return Content(HttpStatusCode.InternalServerError, e.Message);
            }

        }
        #endregion

        #region " Allocate Job to Employee   "
        [HttpPost]
        public IHttpActionResult AllocateJob(JobsViewModel Job)
        {
            try
            {
                // get the job allocation from form and update in jobworks table
                return Ok();
            }
            catch (Exception ex)
            {
                new Error().logAPIError(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), ex.StackTrace);
                return Content(HttpStatusCode.InternalServerError, "An error occured! please try again later");
            }
        }

        #endregion

        #region " Split Job                  "
        [HttpPost]
        public IHttpActionResult SplitJob(List<SplitJobsViewModel> jobs)
        {
            try
            {
                // get the list of number of splits and allocation to employee by coordinattor and update db
                return Ok();
            }
            catch (Exception ex)
            {
                new Error().logAPIError(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), ex.StackTrace);
                return Content(HttpStatusCode.InternalServerError, "An error occured! please try again later");
            }
        }
        #endregion

        #region " Get MT Jobs for Employee   "
        [HttpGet]
        public IHttpActionResult GetMTJobs()
        {
            try
            {
                // return list of MT jobs avalilable from database through sp
                return Ok();
            }
            catch (Exception ex)
            {
                new Error().logAPIError(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), ex.StackTrace);
                return Content(HttpStatusCode.InternalServerError, "An error occured! Please again later");
            }
        }
        #endregion

        #region " Get AQA Jobs for Employee  "
        [HttpGet]
        public IHttpActionResult GetAQAJobs()
        {
            try
            {
                // return list of AQA jobs avalilable from database through sp
                return Ok();
            }
            catch (Exception ex)
            {
                new Error().logAPIError(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), ex.StackTrace);
                return Content(HttpStatusCode.InternalServerError, "An error occured!");
            }
        }
        #endregion

        #region" Get QA Jobs for Employees  "
        public IHttpActionResult GetQAJobs()
        {
            try
            {
                // return list of QA jobs avalilable from database through sp
                return Ok();

            }
            catch (Exception ex)
            {
                new Error().logAPIError(System.Reflection.MethodBase.GetCurrentMethod().Name, ex.ToString(), ex.StackTrace);
                return Content(HttpStatusCode.InternalServerError, "Anerror occured! please try again later");
            }
        }
        #endregion

      
    }
}