using CIS174_TestCoreApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Services
{
    public class ErrorLogService
    {
        private readonly ErrorLogContext _errorLogContext;

        public ErrorLogService(ErrorLogContext errorLogContext)
        {
            _errorLogContext = errorLogContext;
        }

        static public void Go(ErrorLog errorLog)
        {
            
        }
    }
}
