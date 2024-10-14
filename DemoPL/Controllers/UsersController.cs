using AutoMapper;
using Demo.DAL.Model;
using DemoPL.Helpers;
using DemoPL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPL.Controllers
{
	public class UsersController : Controller
	{
		private readonly UserManager<ApplicationUser> _userManager;
		private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly IMapper _mapper;

        public UsersController(UserManager<ApplicationUser> userManager,SignInManager<ApplicationUser> signInManager,IMapper mapper)
        {
			_userManager = userManager;
			_signInManager = signInManager;
            _mapper = mapper;
        }
        public async Task<IActionResult> Index(string email)
		{
			if (string.IsNullOrEmpty(email))
			{
				var users = await _userManager.Users.Select(U => new UserViewModel()
				{
					Id=U.Id,
					FName = U.FName,
					LName = U.LName,
					Email =U.Email,
					PhoneNumber =U.PhoneNumber,
					Roles = _userManager.GetRolesAsync(U).Result
				}).ToListAsync();
				return View(users);

			}
            else
            {
				var user = await _userManager.FindByEmailAsync(email);
				
				var MappedUser = new UserViewModel()
				{
					Id = user.Id,
					FName = user.FName,
					LName = user.LName,
					Email = user.Email,
					PhoneNumber = user.PhoneNumber,
					Roles = _userManager.GetRolesAsync(user).Result

				};
				return View(new List<UserViewModel> { MappedUser });
				
				
            }
        }




       // [HttpGet]
        public async Task<IActionResult> Details(string id, string ViewName = "Details")
        {
            if (id is null)
                return BadRequest();// 400
			
			
			else {

                var user = await _userManager.FindByIdAsync(id);
                if (user is null)
                    return NotFound();//404
                var MappedUser = _mapper.Map<ApplicationUser, UserViewModel>(user);

                return View(ViewName, MappedUser);
            }

        }



        //[HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            return await Details(id, "Edit");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] string id, UserViewModel userVM)
        {
            if (id != userVM.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    var user =await _userManager.FindByIdAsync(id);

                    user.FName=userVM.FName;
                    user.LName=userVM.LName;
                    user.PhoneNumber=userVM.PhoneNumber;
                 // user.Email=userVM.Email;
                 //   user.SecurityStamp= Guid.NewGuid().ToString();
                 await  _userManager.UpdateAsync(user);
 
                    return RedirectToAction(nameof(Index));
                }

                catch (Exception ex)
                {
                    // 1.Log Expection
                    // 2.Friendly Message

                    ModelState.AddModelError(string.Empty, ex.Message);

                }

            }

            return View(userVM);


        }



        
        
        public Task<IActionResult> Delete(string id)
        {
            return Details(id, "Delete");



        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ConfirmDelete(string id)
        {
           

            try
            {
                var user = await _userManager.FindByIdAsync(id);
                  await  _userManager.DeleteAsync(user);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // 1.Log Excpetion
                // 2.Friendly Message

                ModelState.AddModelError(string.Empty, ex.Message);

                return RedirectToAction("Error","Home");
            }
        }


    }
}
