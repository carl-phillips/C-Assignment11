using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Services
{
    public class LogService
    {
        private LogContext _logContext;

        public LogService(LogContext logContext)
        {
            _logContext = logContext;
        }
    }
}
