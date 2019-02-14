using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.Entities;
using WebStore.DomainEntities.Filters;

namespace WebStore.Infrasructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Brand> GetBrands();
        IEnumerable<Section> GetSections();
        IEnumerable<Product> GetProducts(ProductFilter filter);

        int GetBrandProductCount(int brandId);
    }
}
