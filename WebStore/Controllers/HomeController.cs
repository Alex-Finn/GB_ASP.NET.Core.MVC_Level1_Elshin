using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
        {
            new EmployeeView
            {
                Id = 1,
                FirstName = "Семён",
                SecondName = "Семёнов",
                Patronymic = "Семёнович",
                Age = 10
            },
            new EmployeeView
            {
                Id = 2,
                FirstName = "Валерий",
                SecondName = "Валерьев",
                Patronymic = "Валерьевич",
                Age = 20
            },
            new EmployeeView
            {
                Id = 3,
                FirstName = "Фёдор",
                SecondName = "Фёдоров",
                Patronymic = "Фёдорович",
                Age = 30
            }
        };

        public IActionResult Index()
        {
            return View(_employees);
        }

        public IActionResult Details(int id)
        {
            foreach (var item in _employees)
            {
                if (item.Id == id)
                    return View(item);
            }
            return View("Index");
        }
    }
}