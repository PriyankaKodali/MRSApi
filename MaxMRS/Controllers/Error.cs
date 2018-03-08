using MaxMRS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MaxMRS.Controllers
{
    public class Error
    {
        public void logAPIError(string Method, string Message, string StackTrace)
        {
            try
            {
                using (MaxMRSEntities db = new MaxMRSEntities())
                {
                    ExceptionLog el = new ExceptionLog();
                    el.Method = Method;
                    el.Message = Message;
                    el.StackTrace = StackTrace;
                    el.Time =DateTime.Now;
                    db.ExceptionLogs.Add(el);
                    db.SaveChanges();
                }
                return;
            }
            catch (Exception ex)
            {
                return;
            }
        }

    }
}