using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.ViewModels;
using WebStore.Models;

namespace WebStore.Interfaces.Services
{
    public interface IEmployesData
    {
        /// <summary>
        /// Получение списка сотрудников
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeViewModel> GetAll();

        /// <summary>
        /// Получение сотрудника по его Id
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns></returns>
        EmployeeViewModel GetById(int id);

        EmployeeViewModel UpdateEmployee(int id, EmployeeViewModel employee);

        /// <summary>
        /// Метод добавления нового сотрудника
        /// </summary>
        /// <param name="newEmployee">Новый сотрудник для добавления в список</param>
        void AddNew(EmployeeViewModel newEmployee);

        /// <summary>
        /// Метод удаления сотрудника из списка
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        void Delete(int id);

        void SaveChanges();
    }
}
