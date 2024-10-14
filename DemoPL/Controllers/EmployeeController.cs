using AutoMapper;
using Demo.BLL.Interfaces;
using Demo.DAL.Model;
using DemoPL.Helpers;
using DemoPL.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoPL.Controllers
{ 
    public class EmployeeController : Controller
    {
        // private readonly IEmployeeRepository _EmployeeRebo;
        private readonly IUnitOfWork _unitOfWork;

        private readonly IMapper _mapper;

        // Inhertance : EmployeeController is a Controller
        // Association(Composition{Required}) : EmployeeController has a EmployeeRepository

        public EmployeeController(/*IEmployeeRepository EmployeeRebo ,*/IMapper mapper,IUnitOfWork unitOfWork  ) // Ask CLR for Creating Object from Class Implementing IEmployeeRepository
        {
            //_EmployeeRebo = EmployeeRebo;
           
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }




        // Employee/Index
        public async Task<IActionResult> Index(string searchInp)
        {
           // IEnumerable<Employee> employee;
            // OR

          var employee = Enumerable.Empty<Employee>();

            if (string.IsNullOrEmpty(searchInp))
                employee = await _unitOfWork.EmployeeRepository.GetAll();
          
            else
                employee = _unitOfWork.EmployeeRepository.SearchEmployee(searchInp.ToLower());
           
            var MappedEmployee = _mapper.Map<IEnumerable<Employee>, IEnumerable<EmployeeViewModel>>(employee);
                return View(MappedEmployee);

           // TempData.Keep();

            // Binding Through View's Dictionary : Transfer Data From Action To View [One Way]
            /// 1.ViewData Dyctionary Type Property (Introduced in ASP.Net FrameWork 3.5)
            /// => it Helps Us To Transfer The Data From Controller [Action] to View 
            ///ViewData["Message"] = "Hellow ViewData"; //
            /// 2.ViewBag is A Dynamic Type Property (Introduced In ASP.Net FrameWork In 4.0 Based On dynamic Feature )
            /// => It Helps US To Transfer Data From Controller[Action] To View
            ///ViewBag.Message = "Hellow ViewBag";


          

        }



        [HttpGet]
        public IActionResult Create()
        {
            //ViewData["Departments"] = _departmentRepo.GetAll();
            //ViewBag.Departments = _departmentRepo.GetAll();
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)// server Side Validation
            {
         
                employeeVM.ImageName=DocumentSettings.UploadFile(employeeVM.Image, "images");

                var MapppedEmp = _mapper.Map<EmployeeViewModel,Employee>(employeeVM);


               await _unitOfWork.EmployeeRepository.Add(MapppedEmp);

               await _unitOfWork.Complete();
             
                return RedirectToAction(nameof(Index));
               
                    
            }
            return View(employeeVM);
        }
        // /Employee/Details/100
        // /Employee/Details
        
        
        
        
        
        [HttpGet]
        public async Task<IActionResult> Details(int? id, string ViewName = "Details")
        {
            if (!id.HasValue)
                return BadRequest();// 400

            var Employee =await _unitOfWork.EmployeeRepository.Get(id.Value);
            if (Employee is null)
                return NotFound();//404
            var MappedEmployee = _mapper.Map<Employee, EmployeeViewModel>(Employee);


            return View(ViewName, MappedEmployee);

        }

     
        
        
        //[HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            return await Details(id, "Edit");

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromRoute] int id, EmployeeViewModel  employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();

            if (ModelState.IsValid)
            {
                try
                {
                    var MappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);
                    _unitOfWork.EmployeeRepository.Update(MappedEmp);
                  await  _unitOfWork.Complete();
                    return RedirectToAction(nameof(Index));
                }

                catch (Exception ex)
                {
                    // 1.Log Expection
                    // 2.Friendly Message

                    ModelState.AddModelError(string.Empty, ex.Message);

                }

            }

            return View(employeeVM);


        }


       
        
        
        //[HttpGet]        
        public async Task<IActionResult> Delete(int? id)
        {
            return await Details(id, "Delete");



        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete([FromRoute] int id, EmployeeViewModel employeeVM)
        {
            if (id != employeeVM.Id)
                return BadRequest();

            try
            {
                var MappedEmp = _mapper.Map<EmployeeViewModel, Employee>(employeeVM);

                _unitOfWork.EmployeeRepository.Delete(MappedEmp);
                var count = await _unitOfWork.Complete();
                if (count > 0)
                    DocumentSettings.DeleteFile(employeeVM.ImageName, "images");
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                // 1.Log Excpetion
                // 2.Friendly Message

                ModelState.AddModelError(string.Empty, ex.Message);

                return View(employeeVM);
            }
        }
    }
}
