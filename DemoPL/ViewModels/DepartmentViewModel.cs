using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using Demo.DAL.Model;

namespace Demo.PL.ViewModels
{
    public class DepartmentViewModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Code Is Required!!")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Name Is Required!!")]
        [MaxLength(20, ErrorMessage = "Max Length Of Name is 50 Chars")]
        [MinLength(5, ErrorMessage = "Min Length Of Name is 5 Chars")]
        public string Name { get; set; }
        [Display(Name = "Date Of Creation")]
        public DateTime DateOfCreation { get; set; }


        //[InverseProperty(nameof(Employee.Department))]
        // Navigational Property => [Many]
        public ICollection<Employee> Employees { get; set; } = new HashSet<Employee>();
    }
}
