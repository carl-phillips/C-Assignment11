using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Models
{
    public class HouseViewModel
    {
        public int Id { get; set; }
        public string Bedrooms { get; set; }
        public string SquareFeet { get; set; }
        public DateTime DateBuilt { get; set; }
        public string Flooring { get; set; }
        
    }
}
