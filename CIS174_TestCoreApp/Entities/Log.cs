using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Entities
{
    public class Log
    {
        [Key]
        public Guid RequestId { get; set; }
        public int HttpStatusCode { get; set; }
        public DateTime TimeOfLog { get; set; }
        public String Request { get; set; }
        public String Response { get; set; }
    }
}
