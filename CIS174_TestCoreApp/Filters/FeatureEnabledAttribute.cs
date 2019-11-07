using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace CIS174_TestCoreApp.Controllers.api
{
    internal class FeatureEnabledAttribute : Attribute, IResourceFilter
    {
        public bool IsEnabled { get; set; }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            //Nothing
        }

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            if(!IsEnabled)
            {
                context.Result = new BadRequestResult();
            }
        }
    }
}