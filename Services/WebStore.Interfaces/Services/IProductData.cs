using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.DTO.Product;
using WebStore.DomainEntities.Entities;

namespace WebStore.Interfaces.Services
{
    public interface IProductData
    {
        IEnumerable<Brand> GetBrands();
        IEnumerable<Section> GetSections();

        IEnumerable<ProductDTO> GetProducts(ProductFilter Filter = null);
        ProductDTO GetProductById(int id);
    }
}
