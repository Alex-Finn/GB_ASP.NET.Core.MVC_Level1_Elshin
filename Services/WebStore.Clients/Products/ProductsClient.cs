using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Configuration;
using WebStore.Clients.Base;
using WebStore.DomainEntities.DTO.Product;
using WebStore.DomainEntities.Entities;
using WebStore.Interfaces.Services;

namespace WebStore.Clients.Products
{
    public class ProductsClient : BaseClient, IProductData
    {
        public ProductsClient(IConfiguration configuration) : base(configuration)
        {
            ServiceAddress = "api/Products";
        }

		public IEnumerable<Section> GetSections()
		{
			return Get<List<Section>>($"{ServiceAddress}/sections");
		}

		public Section GetSectionById(int id)
		{
			return Get<Section>($"{ServiceAddress}/sections/{id}");
		}

		public IEnumerable<Brand> GetBrands()
		{
			return Get<List<Brand>>($"{ServiceAddress}/brands");
		}

		public Brand GetBrandById(int id)
		{
			return Get<Brand>($"{ServiceAddress}/brands/{id}");
		}

		public IEnumerable<ProductDTO> GetProducts(ProductFilter Filter = null)
		{
			return Post(ServiceAddress, Filter).Content.ReadAsAsync<IEnumerable<ProductDTO>>().Result;
		}

		public ProductDTO GetProductById(int id)
		{
			return Get<ProductDTO>($"{ServiceAddress}/{id}");
		}
	}
}
