using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace Demo.PL.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public RoleController(RoleManager<IdentityRole>roleManager,IMapper mapper)
        {
            _roleManager = roleManager;
            _mapper = mapper;
        }


        public async Task<IActionResult> Index(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                var Roles = await _roleManager.Roles.Select(R => new RoleViewModel()
                {
                  Id = R.Id,
                  RoleName = R.Name
                }).ToListAsync();
                return View(Roles);

            }
            else
            {
                var role = await _roleManager.FindByNameAsync(name);
                if(role is not null)
                {
                    var mappedRole = new RoleViewModel()
                    {
                        Id = role.Id,
                        RoleName = role.Name
                    };
                    return View(new List<RoleViewModel> { mappedRole });
                }
                return View(Enumerable.Empty<RoleViewModel>());
            }
        }


        #region Create

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task <IActionResult> Create (RoleViewModel roleVM)
        {
            if(ModelState.IsValid)
            {
                var MappedRole = _mapper.Map<RoleViewModel, IdentityRole>(roleVM);
                await _roleManager.CreateAsync(MappedRole);

                return RedirectToAction(nameof(Index));

            }
            return View(roleVM);
        }
        #endregion

        #region Details Action
        [HttpGet]
        public async Task<IActionResult> Details(string id, string ViewName = "Details")
        {
            if (id is null)
                return BadRequest();

            var role = await _roleManager.FindByIdAsync(id);

            if (role is null)
                return NotFound();
            var MappedRole = _mapper.Map<IdentityRole, RoleViewModel>(role);

            return View(ViewName, MappedRole);
        }
        #endregion


        #region Edit Action

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {

            return await Details(id, "Edit");

        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, RoleViewModel UpdatedRole)
        {

            if (ModelState.IsValid) // server side validation
            {
                try
                {
                    var role = await _roleManager.FindByIdAsync(id);
                    //role.Id = UpdatedRole.Id;
                    role.Name = UpdatedRole.RoleName;

                    await _roleManager.UpdateAsync(role);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    // log exception
                    //friendly message
                    ModelState.AddModelError(string.Empty, ex.Message);

                }

            }


            return View(UpdatedRole);
        }
        #endregion

        #region Delete Action
        [HttpGet]
        public async Task<IActionResult> Delete(string id)
        {
            return await Details(id, "Delete");

        }

        [HttpPost(Name = "Delete")]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> ConfirmedDeleted(string id)
        {

            if (ModelState.IsValid) // server side validation
            {
                try
                {
                    var role = await _roleManager.FindByIdAsync(id);

                    await _roleManager.DeleteAsync(role);
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {

                    ModelState.AddModelError(string.Empty, ex.Message);
                    return RedirectToAction("Error", "Home");
                }

            }


            return View();

        }
        #endregion

    }
}
