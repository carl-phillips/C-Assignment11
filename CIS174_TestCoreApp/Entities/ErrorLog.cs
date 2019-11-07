using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Entities
{
    public class ErrorLog
    {
        [Key]
        public Guid RequestId { get; set; }
        public int HttpStatusCode { get; set; }
        public DateTime TimeOfError { get; set; }
        public String ExceptionMessage { get; set; }
        public String StackTrace { get; set; }
    }
}
