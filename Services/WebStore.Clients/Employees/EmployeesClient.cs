using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Configuration;
using WebStore.Clients.Base;
using WebStore.DomainEntities.ViewModels;
using WebStore.Interfaces.Services;

namespace WebStore.Clients.Employees
{
    public class EmployeesClient : BaseClient, IEmployesData
    {
        public EmployeesClient(IConfiguration configuration) : base(configuration)
        {
            ServiceAddress = "api/employees";
        }

        public void AddNew(EmployeeViewModel newEmployee)
        {
            Post(ServiceAddress, newEmployee);
        }

        public void Delete(int id)
        {
            Delete($"{ServiceAddress}/{id}");
        }

        public IEnumerable<EmployeeViewModel> GetAll()
        {
            return Get<List<EmployeeViewModel>>(ServiceAddress);
        }

        public EmployeeViewModel GetById(int id)
        {
            return Get<EmployeeViewModel>($"{ServiceAddress}/{id}");
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel UpdateEmployee(int id, EmployeeViewModel employee)
        {
            var response = Put($"{ServiceAddress}/{id}", employee);
            return response.Content.ReadAsAsync<EmployeeViewModel>().Result;
        }
    }
}
