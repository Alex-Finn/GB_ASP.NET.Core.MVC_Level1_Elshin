using System;
using System.Collections.Generic;
using System.Text;
using WebStore.DomainEntities.Entities.Base.Interfaces;

namespace WebStore.DomainEntities.DTO.Product
{
    public class ProductDTO : INamedEntity, IOrderedEntity
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Order { get; set; }

        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public BrandDTO Brand { get; set; }
    }
}
