﻿using System.Collections.Generic;
using WebStore.DomainEntities.Entities.Base.Interfaces;

namespace WebStore.DomainEntities.ViewModels
{
    public class CatalogViewModel
    {
        public int? BrandId { get; set; }
        public int? SectionId { get; set; }

        public IEnumerable<ProductViewModel> Products { get; set; }
    }
    public class ProductViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
    }
}
