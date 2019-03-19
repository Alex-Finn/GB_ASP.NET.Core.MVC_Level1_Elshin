using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.DomainEntities.DTO.Product;
using WebStore.DomainEntities.Entities;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{    
    [ApiController, Route("api/[controller]"), Produces("application/json")]
    public class ProductsController : ControllerBase, IProductData
    {
        private readonly IProductData _productData;
        public ProductsController(IProductData productData)
        {
            _productData = productData;
        }

        [HttpGet("brands")]
        public IEnumerable<Brand> GetBrands()
        {
            return _productData.GetBrands();
        }

        [HttpGet("{id}"), ActionName("Get")]
        public ProductDTO GetProductById(int id)
        {
            return _productData.GetProductById(id);
        }

        [HttpPost, ActionName("Post")]
        public IEnumerable<ProductDTO> GetProducts([FromBody]ProductFilter Filter = null)
        {
            return _productData.GetProducts(Filter);
        }

        [HttpGet("sections")]
        public IEnumerable<Section> GetSections()
        {
            return _productData.GetSections();
        }
    }
}