using CIS174_TestCoreApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Filters
{
    public class HandleExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            Log log = context.HttpContext.Items["LogContext"] as Log;
            var error = new ErrorLog
            {
                HttpStatusCode = context.HttpContext.Response.StatusCode,
                TimeOfError = DateTime.Now,
                RequestId = log.RequestId,
                ExceptionMessage = context.Exception.Message,
                StackTrace = context.Exception.StackTrace,
            };

            ErrorLogContext errorLogContext = new ErrorLogContext();

            errorLogContext.Add(error);
            errorLogContext.SaveChanges();

            dynamic o = new JObject();
            o = error;
            string json = o.ToString();

            context.Result = new ObjectResult(error)
            {
                Value = json
            };
            
            context.ExceptionHandled = true;
        }
    }
}
