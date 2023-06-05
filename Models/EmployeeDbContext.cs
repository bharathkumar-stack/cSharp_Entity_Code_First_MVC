using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace EF_Code_First_MVC_Employe_Crud.Models
{
    public class EmployeeDbContext :DbContext
    {
        public EmployeeDbContext()
        {

        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
    }
}