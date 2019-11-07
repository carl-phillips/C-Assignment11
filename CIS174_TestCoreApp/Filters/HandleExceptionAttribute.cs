using CIS174_TestCoreApp.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Filters
{
    public class HandleExceptionAttribute : ExceptionFilterAttribute
    {
        private readonly ErrorLogContext _errorLogContext;
        public override void OnException(ExceptionContext context)
        {
            var error = new ErrorLog
            {
                HttpStatusCode = context.HttpContext.Response.StatusCode,
                TimeOfError = DateTime.Now,
                RequestId = Guid.NewGuid(),
                ExceptionMessage = context.Exception.Message,
                StackTrace = context.Exception.StackTrace,
            };

            _errorLogContext.Add(error);
            _errorLogContext.SaveChanges();

            context.Result = new ObjectResult(error)
            {
                StatusCode = error.HttpStatusCode
            };

            context.ExceptionHandled = true;
        }
    }
}
