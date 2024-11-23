using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jobayer_alam_24_CRUDinCoreMVC.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        [Display(Name = "Department Name")]
        public int DepartmentId { get; set; }

        public Department? Department { get; set; }
    }
}