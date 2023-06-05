using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF_Code_First_MVC_Employe_Crud.Models
{
    public class EmployeeViewModel
    {
        public IEnumerable<Department> Department { get; set; }
        public Employee Employee { get; set; }
    }
}