using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.Entities;

namespace WebStore.Infrasructure.Interfaces
{
    public interface IProductData
    {
        IEnumerable<Brand> GetBrands();
        IEnumerable<Section> GetSections();
        IEnumerable<Product> GetProducts();

        int GetBrandProductCount(int brandId);
    }
}
