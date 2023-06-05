using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace EF_Code_First_MVC_Employe_Crud.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        [Display(Name = "EmployeeName")]
        public String EmployeeName { get; set; }
        [Display(Name = "designation")]
        public String EmployeeDesignation { get; set; }

        [Display(Name = "Address")]
        public String EmployeeAddress { get; set; }

        [Display(Name = "Passport")]
        public String EmployeePassport { get; set; }

        [Display(Name = "phone")]
        public String Employeephone { get; set; }

        [Display(Name = "gender")]
        public String EmployeeGender { get; set; }

        [Display(Name = "city")]
        public String city { get; set; }

        [Display(Name = "project")]
        public String project { get; set; }

        [Display(Name = "companyName")]
        public String companyName { get; set; }

        [Display(Name = "PinCode")]
        public String Pincode { get; set; }

        public Department department { get; set; }
    }
}