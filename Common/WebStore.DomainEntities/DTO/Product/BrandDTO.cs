using System;
using System.Collections.Generic;
using System.Text;
using WebStore.DomainEntities.Entities.Base.Interfaces;

namespace WebStore.DomainEntities.DTO.Product
{
    public class BrandDTO : INamedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
