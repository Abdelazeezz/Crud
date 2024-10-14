using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Model;
using Demo.PL.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoPL.Controllers
{
    [Authorize]
    public class DepartmentController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        //private readonly IDepartmentRepository _departmentsRepo; // Null

        public DepartmentController(IUnitOfWork unitOfWork, IMapper mapper/*, IDepartmentRepository departmentsRepo*/)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            //_departmentsRepo = /*new DepartmentRepository();*/

            //_departmentsRepo = departmentsRepo;
        }


        // /Department/Index
        public async Task<IActionResult> Index()
        {
            var departments = await  _unitOfWork.DepartmentRepository.GetAll();

            var mappedDeps = _mapper.Map<IEnumerable<Department>, IEnumerable<DepartmentViewModel>>(departments);
            return View(mappedDeps);
        }

        //  /Department/Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task <IActionResult> Create(DepartmentViewModel departmentVM)
        {
            if (ModelState.IsValid) // Server Side Validation
            {
                var mappedDep = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
              await  _unitOfWork.DepartmentRepository.Add(mappedDep);
                var Count = await _unitOfWork.Complete();
                if (Count > 0)
                {
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(departmentVM);
        }

        // /Department/Details/100
        // /Department/Details
        [HttpGet]
        public async Task<IActionResult> Details(int? id, string viewName = "Details")
        {
            //if (id is null)
            if (!id.HasValue)
                return BadRequest(); // 400
            var department = await _unitOfWork.DepartmentRepository.Get(id.Value);
            var mappedDep = _mapper.Map<Department, DepartmentViewModel>(department);
            if (department is null)
                return NotFound(); // 404
            return View(viewName, mappedDep);
        }


        // /Department/Edit/1
        // /Department/Edit
        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            

            return await Details(id, "Edit");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, DepartmentViewModel departmentVM)
        {
            if (id != departmentVM.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    var mappedDep = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                    _unitOfWork.DepartmentRepository.Update(mappedDep);
                   await _unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }
                catch (Exception ex)
                {
                    // 1. Log Exception
                    // 2. Friendly Message

                    ModelState.AddModelError(string.Empty, ex.Message);

                }
            }
            return View(departmentVM);
        }


        // /Department/Delete/10
        // /Department/Delete
        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id, DepartmentViewModel departmentVM)
        {
            if (id != departmentVM.Id)
                return  BadRequest();
            try
            {
                var mappedDep = _mapper.Map<DepartmentViewModel, Department>(departmentVM);
                _unitOfWork.DepartmentRepository.Delete(mappedDep);
               await _unitOfWork.Complete();
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // 1. Log Exception
                // 2. Friendly Message
                ModelState.AddModelError(string.Empty, ex.Message);
                return View(departmentVM);
            }
        }
    }
}
