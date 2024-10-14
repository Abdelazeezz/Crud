using System.ComponentModel.DataAnnotations;

namespace DemoPL.ViewModels
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Password Is Required ")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Required ")]
        [Compare(nameof(NewPassword), ErrorMessage = "Confirm Password does not match password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

 


    }
}
