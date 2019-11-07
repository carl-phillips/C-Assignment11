using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Entities
{
    public class Accomplishment
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime DateOfAccomplishment { get; set; }
    }
}
