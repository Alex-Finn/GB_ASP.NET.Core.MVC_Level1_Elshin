using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebStore.DomainEntities.ViewModels
{
    public class EmployeeViewModel
    {
        //[Editable(allowEdit: true)]       не совладал с атрибутом
        [Display(Name = "ID")]
        public int Id { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите Имя")]
        [RegularExpression(pattern: "^[A-ZА-ЯЁ][a-zа-яё]*-?([A-ZА-ЯЁ][a-zа-яё]*)?", ErrorMessage = "Имя может состоять только из букв и начинаться с заглавной")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите фамилию")]
        [RegularExpression(pattern: "^[A-ZА-ЯЁ][a-zа-яё]*-?([A-ZА-ЯЁ][a-zа-яё]*)?", ErrorMessage = "Фамилия может состоять только из букв и начинаться с заглавной")]
        [Display(Name = "Фамилия")]
        public string SecondName { get; set; }

        [RegularExpression(pattern: "^[A-ZА-ЯЁ][a-zа-яё]*", ErrorMessage = "ОТчество может состоять только из букв и начинаться с заглавной")]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Введите возраст")]
        [Display(Name = "Возраст")]
        [Range(minimum: 18, maximum: 110, ErrorMessage ="Возраст может быть от 18 до 110 лет")]
        public int Age { get; set; }
    }
}
