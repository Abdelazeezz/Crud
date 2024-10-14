using Demo.DAL.Model;
using DemoPL.Helpers;
using DemoPL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace DemoPL.Controllers
{
    public class AccountController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }




        #region SignUp

        //[HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUpAsync(SignUpViewModel model)
        {
            if (ModelState.IsValid) // Server Side Validation
            {
                var user = await _userManager.FindByNameAsync(model.UserName);

                if (user is null)
                {
                    user = new ApplicationUser()
                    {
                        UserName = model.UserName,
                        Email = model.Email,
                        IsAgree = model.IsAgree,
                        FName = model.FName,
                        LName = model.LName,


                    };

                    var Result = await _userManager.CreateAsync(user, model.Password);
                    if (Result.Succeeded)
                        return RedirectToAction(nameof(SignIn));

                }

                ModelState.AddModelError(string.Empty, "User Name is already exists : ");

            }

            return View(model);
        }

        #endregion

        #region SignIn
        public IActionResult SignIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);
                if (user is not null)
                {
                    var flag = await _userManager.CheckPasswordAsync(user, model.Password);

                    if (flag)
                    {
                        var result = await _signInManager.PasswordSignInAsync(user, model.Password, model.RememberMe, false);

                        if (result.Succeeded)
                            return RedirectToAction(nameof(HomeController.Index), "Home");

                    }


                }
                ModelState.AddModelError(string.Empty, "Invalid Login !");


            }

            return View(model);
        }

        #endregion

        #region SignOut

        public async new Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(SignIn));
        }

        #endregion

        #region Forget Password

        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> SendResetPassword(ForgetPasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userManager.FindByEmailAsync(model.Email);

                if (user is not null)
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(user); // Unique for this User for one-Time
                    var resetPasswordUrl = Url.Action("ResetPassword", "Account", new { email = model.Email, token }, Request.Scheme/*, "https", "localhost:44320"*/);

                    //https://localhost:44320/Account/ResetPassword?email=ali@gmail.com&token

                    var email = new Email()
                    {
                        Subject = "Reset Your Password ",
                        Recipients = model.Email,
                        Body = resetPasswordUrl

                    };

                    EmailSettings.SendEmail(email);
                    return RedirectToAction(nameof(CheckYourInbox));
                }

                ModelState.AddModelError(string.Empty, "Invalid Email");



            }



            return View(model);


        }


        public IActionResult CheckYourInbox()
        {
            return View();

        }

        #endregion

        #region Reset Password

        public IActionResult ResetPassword(string email, string token)
        {

            TempData["email"] = email;
            TempData["token"] = token;

            return View();
        }


        [HttpPost]

        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model)
        {
            var email = TempData["email"] as string;
            string token = TempData["token"] as string;

            var user = await _userManager.FindByEmailAsync(email);

            var result = await _userManager.ResetPasswordAsync(user, token, model.NewPassword);

            if (result.Succeeded)
                return RedirectToAction(nameof(SignIn));

            foreach (var error in result.Errors)
                ModelState.AddModelError(string.Empty, error.Description);


            return View(model);
        }

    }





    #endregion








}

