using System.ComponentModel.DataAnnotations;

namespace DemoPL.ViewModels
{
    public class SignUpViewModel
    {
        [Required(ErrorMessage = "UserName Is Requried !")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "First Name Is Requried !")]
        public string FName { get; set; }
       
        [Required(ErrorMessage = "Last Name Is Requried !")]
        public string LName { get; set; }




        [Required(ErrorMessage ="Email Is Requried !")]
        [EmailAddress(ErrorMessage ="Invalid Email")]
        public string Email { get; set; }
        
        [Required(ErrorMessage ="Password Is Required ")]
        [MinLength(5,ErrorMessage ="Minimum Password Length is 5")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password Is Required ")]
        [Compare(nameof(Password),ErrorMessage ="Confirm Password does not match password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        public bool IsAgree { get; set; }





    }
}
