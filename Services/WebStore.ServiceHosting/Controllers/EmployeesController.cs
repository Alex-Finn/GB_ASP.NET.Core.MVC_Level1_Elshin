using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebStore.DomainEntities.ViewModels;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{
    [ApiController, Route("api/[controller]"), Produces("application/json")]
    public class EmployeesController : ControllerBase, IEmployesData
    {
        private readonly IEmployesData _employesData;
        public EmployeesController(IEmployesData employesData) => _employesData = employesData;

        [HttpPost, ActionName("Post")]
        public void AddNew(EmployeeViewModel newEmployee)
        {
            _employesData.AddNew(newEmployee);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _employesData.Delete(id);
        }

        [HttpGet, ActionName("Get")]
        public IEnumerable<EmployeeViewModel> GetAll()
        {
            return _employesData.GetAll();
        }

        [HttpGet("{id}"), ActionName("Get")]
        public EmployeeViewModel GetById(int id)
        {
            return _employesData.GetById(id);
        }

        [NonAction]
        public void SaveChanges()
        {
            _employesData.SaveChanges();
        }

        [HttpPut("{id}"), ActionName("Put")]
        public EmployeeViewModel UpdateEmployee(int id, EmployeeViewModel employee)
        {
            return _employesData.UpdateEmployee(id, employee);
        }
    }
}