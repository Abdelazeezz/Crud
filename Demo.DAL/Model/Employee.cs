﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demo.DAL.Model
{
    public class Employee:ModelBase
    {
        public string Name { get; set; }

        
        public int? Age { get; set; }
        
       
        public string Address { get; set; }
        
      
        public decimal Salary { get; set; }

        public bool IsActive { get; set; }
        
        public string Email { get; set; }

       
        public string PhoneNumber { get; set; }

       
        public DateTime HireDate { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreationDate { get; set; }

        public string ImageName { get; set; }

        // [ForeignKey("Department")]
        public int? DepartmentId { get; set; } //FK Column

        //[InverseProperty(nameof(Models.Department.Employees))]
        // Navigational Property => [ONE] [Related Data]
        public Department Department { get; set; }










    }
}
