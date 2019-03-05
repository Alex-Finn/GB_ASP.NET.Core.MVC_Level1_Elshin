using System;
using System.Collections.Generic;
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
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EmployeeViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public EmployeeViewModel UpdateEmployee(int id, EmployeeViewModel employee)
        {
            throw new NotImplementedException();
        }
    }
}
