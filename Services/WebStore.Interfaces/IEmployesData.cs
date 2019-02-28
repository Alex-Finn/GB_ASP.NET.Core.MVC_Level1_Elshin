using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.ViewModels;
using WebStore.Models;

namespace WebStore.Interfaces
{
    public interface IEmployesData
    {
        /// <summary>
        /// Получение списка сотрудников
        /// </summary>
        /// <returns></returns>
        IEnumerable<EmployeeViewModel> Get();

        /// <summary>
        /// Получение сотрудника по его Id
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns></returns>
        EmployeeViewModel GetById(int id);

        /// <summary>
        /// Метод добавления нового сотрудника
        /// </summary>
        /// <param name="newEmployee">Новый сотрудник для добавления в список</param>
        void AddNewEmployee(EmployeeViewModel newEmployee);

        /// <summary>
        /// Метод удаления сотрудника из списка
        /// </summary>
        /// <param name="id">Идентификатор сотрудника</param>
        void DeleteEmployee(int id);

        void SaveChanges();
    }
}
