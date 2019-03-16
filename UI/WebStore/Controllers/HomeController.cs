using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebStore.Interfaces.Api;
using WebStore.Models;

namespace WebStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult CheckOut() => View();

        public IActionResult Cart() => View();

        public IActionResult Blog() => View();

        public IActionResult BlogSingle() => View();

        public IActionResult ErrorPage404() => View();

        public IActionResult ErrorStatus(string id)
        {
            switch (id)
            {
                case "404":
                    return RedirectToAction(nameof(ErrorPage404));
                default:
                    return Content($"Статусный код ошибки {id}");
            }
        }

        public IActionResult ContactUs() => View();

        public IActionResult ValuesServicetest([FromServices] IValueService _valueService) => View(_valueService.Get());
    }
}