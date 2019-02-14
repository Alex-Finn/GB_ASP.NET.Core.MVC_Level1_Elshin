using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.DomainEntities.Entities;
using WebStore.Infrasructure.Interfaces;

namespace WebStore.Infrasructure.Implementations
{
    class InMemoryProductData : IProductData
    {
        //private readonly List<Brand> _brands;
        //private readonly List<Section> _sections;
        //private readonly List<Product> _products;

        public int GetBrandProductCount(int brandId)
        {
            return TestData.Products.Count(product => product.BrandId == brandId);
        }

        public IEnumerable<Brand> GetBrands()
        {
            return TestData.Brands;
        }

        public IEnumerable<Product> GetProducts()
        {
            return TestData.Products;
        }

        public IEnumerable<Section> GetSections()
        {
            return TestData.Sections;
        }
    }
}
