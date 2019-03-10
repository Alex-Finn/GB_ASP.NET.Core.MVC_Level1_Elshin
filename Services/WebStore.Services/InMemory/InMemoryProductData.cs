using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Data;
using WebStore.DomainEntities.DTO.Product;
using WebStore.DomainEntities.Entities;
using WebStore.Interfaces.Services;
using WebStore.Services.Map;

namespace WebStore.Implementations
{
    class InMemoryProductData : IProductData
    {
        public IEnumerable<Brand> GetBrands() => TestData.Brands;

        public IEnumerable<Section> GetSections() => TestData.Sections;
        public IEnumerable<ProductDTO> GetProducts(ProductFilter Filter = null)
        {
            if (Filter is null) return TestData.Products.Select(ProductDTO2Product.Map);
            var result = TestData.Products.AsEnumerable();
            if (Filter.BrandId != null)
                result = result.Where(product => product.BrandId == Filter.BrandId);
            if (Filter.SectionId != null)
                result = result.Where(product => product.SectionId == Filter.SectionId);
            return result.Select(ProductDTO2Product.Map);
        }

        public ProductDTO GetProductById(int id)
        {
            return TestData.Products.FirstOrDefault(p => p.Id == id).Map();
        }
    }
}
