using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrasructure.Interfaces;
using WebStore.Models;

namespace WebStore.Infrasructure.Implementations
{
    class InMemoryEmployesData : IEmployesData
    {
        /// <summary>
        /// Спискок сотрудников
        /// </summary>
        private readonly List<EmployeeViewModel> _employees = new List<EmployeeViewModel>
        {
            new EmployeeViewModel
            {
                Id = 1,
                FirstName = "Семён",
                SecondName = "Семёнов",
                Patronymic = "Семёнович",
                Age = 10
            },
            new EmployeeViewModel
            {
                Id = 2,
                FirstName = "Валерий",
                SecondName = "Валерьев",
                Patronymic = "Валерьевич",
                Age = 20
            },
            new EmployeeViewModel
            {
                Id = 3,
                FirstName = "Фёдор",
                SecondName = "Фёдоров",
                Patronymic = "Фёдорович",
                Age = 30
            }
        };
        
        /// <summary>
        /// Метод добавления нового сотрудника
        /// </summary>
        /// <param name="newEmployee">Новый сотрудник для добавления в список</param>
        public void AddNewEmployee(EmployeeViewModel newEmployee)
        {
            if (_employees.Contains(newEmployee)) return;
            newEmployee.Id = _employees.Max(emp => emp.Id) + 1;
            _employees.Add(newEmployee);
        }

        /// <summary>
        /// Метод удаления сотрудника из списка
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        public void DeleteEmployee(int id)
        {
            var employee = GetById(id);
            if (employee is null) return;
            _employees.Remove(employee);
        }

        /// <summary>
        /// Получение списка сотрудников
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeViewModel> Get()
        {
            return _employees;
        }

        /// <summary>
        /// Получение сотрудника по его Id
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns></returns>
        public EmployeeViewModel GetById(int id)
        {
            return _employees.FirstOrDefault(emp => emp.Id == id);
        }

        public void SaveChanges()
        {
            
        }
    }
}
