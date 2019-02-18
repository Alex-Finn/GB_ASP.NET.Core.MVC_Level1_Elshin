using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.DomainEntities.Entities;
using WebStore.DomainEntities.Filters;
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

        public Product GetProductById(int id)
        {
            return TestData.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter)
        {
            var products = TestData.Products;
            if (filter.SectionId.HasValue)
                products = products.Where(p =>
                p.SectionId.Equals(filter.SectionId)).ToList();
            if (filter.BrandId.HasValue)
                products = products.Where(p => p.BrandId.HasValue &&
                p.BrandId.Value.Equals(filter.BrandId.Value)).ToList();
            return products;
        }

        public IEnumerable<Section> GetSections()
        {
            return TestData.Sections;
        }
    }
}
