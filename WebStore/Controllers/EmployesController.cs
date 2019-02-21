using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;
using WebStore.Infrasructure.Interfaces;
using Microsoft.AspNetCore.Authorization;

namespace WebStore.Controllers
{
    [Authorize]
    public class EmployesController : Controller
    {
        private readonly IEmployesData _employesData;

        public EmployesController(IEmployesData employesData)
        {
            _employesData = employesData;
        }

        public IActionResult Index()
        {
            return View(_employesData.Get());
        }

        public IActionResult Details(int? id)
        {
            if (id == null) return BadRequest();

            var employee = _employesData.GetById((int)id);
            if (employee == null) return NotFound();

            return View(employee);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return View(new EmployeeViewModel
            {
                FirstName = "Имя",
                SecondName = "Фамилия",
                Patronymic = "Отчество",
                Age = 18
            });

            var employee = _employesData.GetById((int)id);
            if (employee == null) return NotFound();

            return View(employee);
        }

        [HttpPost]
        public IActionResult Edit(EmployeeViewModel model)
        {
            if (!ModelState.IsValid) return View(model);
            if(model.Id == 0)
            {
                _employesData.AddNewEmployee(model);
            }
            else
            {
                var employee = _employesData.GetById(model.Id);
                if (employee == null) return NotFound();
                employee.FirstName = model.FirstName;
                employee.SecondName = model.SecondName;
                employee.Patronymic = model.Patronymic;
                employee.Age = model.Age;
            }
            return RedirectToAction("Index");
        }

        public IActionResult Delete (int? id)
        {
            if (id == null) return BadRequest();
                        
            if (_employesData.GetById((int)id) == null) return NotFound();

            _employesData.DeleteEmployee((int)id);

            return RedirectToAction("Index");

        }
    }
}