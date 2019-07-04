using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.ViewModels;
using WebStore.Interfaces.Services;
using WebStore.Models;

namespace WebStore.Implementations
{
    public class InMemoryEmployesData : IEmployesData
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
        public void AddNew(EmployeeViewModel newEmployee)
        {
            if (_employees.Contains(newEmployee))
                return;
            newEmployee.Id = _employees.Count == 0 ? 1 : _employees.Max(e => e.Id) + 1;
            _employees.Add(newEmployee);
        }

        /// <summary>
        /// Метод удаления сотрудника из списка
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee is null) return;
            _employees.Remove(employee);
        }

        /// <summary>
        /// Получение списка сотрудников
        /// </summary>
        /// <returns></returns>
        public IEnumerable<EmployeeViewModel> GetAll() => _employees;

        public EmployeeViewModel UpdateEmployee(int id, EmployeeViewModel employee)
        {
            if (employee is null) throw new ArgumentNullException(nameof(employee));

            var exists_employee = GetById(id);
            if (exists_employee is null) throw new InvalidOperationException($"Сотрудник с id = {id} не найден");

            exists_employee.FirstName = employee.FirstName;
            exists_employee.SecondName = employee.SecondName;
            exists_employee.Patronymic = employee.Patronymic;
            exists_employee.Age = employee.Age;

            return exists_employee;
        }

        /// <summary>
        /// Получение сотрудника по его Id
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns></returns>
        public EmployeeViewModel GetById(int id) => _employees.FirstOrDefault(emp => emp.Id == id);

        public void SaveChanges() {}
    }
}
