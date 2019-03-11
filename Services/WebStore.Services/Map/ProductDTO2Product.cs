using System;
using System.Collections.Generic;
using System.Text;
using WebStore.DomainEntities.DTO.Product;
using WebStore.DomainEntities.Entities;

namespace WebStore.Services.Map
{
    public static class ProductDTO2Product
    {
        public static ProductDTO Map(this Product product)
        {
            return new ProductDTO
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Order = product.Order,
                ImageUrl = product.ImageUrl,
                Brand = product.Brand is null
                        ? null
                        : new BrandDTO
                        {
                            Id = product.Brand.Id,
                            Name = product.Brand.Name
                        }
            };
        }
    }
}
