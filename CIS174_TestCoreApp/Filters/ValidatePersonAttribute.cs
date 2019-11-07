using CIS174_TestCoreApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Filters
{
    public class ValidatePersonAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var service = (PersonService) context.HttpContext.RequestServices.GetService(typeof(PersonService));
            var personId = (int) context.ActionArguments["id"];
            if (!service.DoesPersonExist(personId))
            {
                context.Result = new NotFoundResult();
            }
        }
    }
}
