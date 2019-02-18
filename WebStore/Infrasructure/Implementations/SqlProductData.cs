using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DAL.Context;
using WebStore.DomainEntities.Entities;
using WebStore.DomainEntities.Filters;
using WebStore.Infrasructure.Interfaces;

namespace WebStore.Infrasructure.Implementations
{
    public class SqlProductData : IProductData
    {
        private readonly WebStroreContext _context;
        public SqlProductData(WebStroreContext context) => _context = context;

        public int GetBrandProductCount(int brandId)
        {
            return _context.Products.Count(p => p.BrandId == brandId);
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands.AsEnumerable();
        }

        public Product GetProductById(int id)
        {
            return _context.Products.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Product> GetProducts(ProductFilter filter = null)
        {
            if (filter is null)
                return _context.Products.AsEnumerable();
            IQueryable<Product> result = _context.Products;
            if (filter.BrandId != null)
                result = result.Where(p => p.BrandId == filter.BrandId);
            if (filter.SectionId != null)
                result = result.Where(p => p.SectionId == filter.SectionId);
            return result.AsEnumerable();
        }

        public IEnumerable<Section> GetSections()
        {
            return _context.Sections.AsEnumerable();
        }
    }
}
