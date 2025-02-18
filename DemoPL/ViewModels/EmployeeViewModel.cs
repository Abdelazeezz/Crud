﻿using Demo.DAL.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoPL.ViewModels
{
    public class EmployeeViewModel
    {
        public int Id { get; set; }


        [Required]
        [MaxLength(50, ErrorMessage = "Max Length Of Name is 50 Chars")]
        [MinLength(5, ErrorMessage = "Min Length Of Name is 5 Chars")]
        public string Name { get; set; }

        [Range(22, 30)]
        public int? Age { get; set; }

        [RegularExpression(@"^[0-9]{1,3}-[a-zA-Z]{5,10}-[a-zA-Z]{4,10}-[a-zA-Z]{5,10}$"
             , ErrorMessage = "Address Must Be Like 123-Street-City-Country")]
        public string Address { get; set; }

        [DataType(DataType.Currency)]
        public decimal Salary { get; set; }

        [Display(Name = "Is Active ")]
        public bool IsActive { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        [Display(Name = "Phone Number ")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Hiring Date")]
        public DateTime HireDate { get; set; }


        public DateTime CreationDate { get; set; }


        public IFormFile Image { get; set; }

        public string ImageName { get; set; }



        // [ForeignKey("Department")]
        public int? DepartmentId { get; set; } //FK Column

        //[InverseProperty(nameof(Models.Department.Employees))]
        // Navigational Property => [ONE] [Related Data]
        public Department Department { get; set; }
    }
}
