using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.Entities.Base;
using WebStore.DomainEntities.Entities.Base.Interfaces;

namespace WebStore.DomainEntities.ViewModels
{
    public class SectionViewModel : INamedEntity, IOrderedEntity
    {
        public string Name { get; set; }
        [HiddenInput(DisplayValue = false)]
        public int Id { get; set; }
        public int Order { get; set; }

        public List<SectionViewModel> ChildSections { get; set; } = new List<SectionViewModel>();
        public SectionViewModel ParentSection { get; set; }
    }
}
