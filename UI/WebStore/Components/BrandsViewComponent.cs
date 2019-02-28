using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.ViewModels;
using WebStore.Interfaces;
using WebStore.Models;

namespace WebStore.Components
{
    public class BrandsViewComponent : ViewComponent
    {
        private readonly IProductData _ProductData;

        public BrandsViewComponent(IProductData ProductData) => _ProductData = ProductData;

        public async Task<IViewComponentResult> InvokeAsync() => View(GetBrands());

        private IEnumerable<BrandViewModel> GetBrands()
        {
            return _ProductData.GetBrands().Select(brand => new BrandViewModel
            {
                Id = brand.Id,
                Name = brand.Name,
                Order = brand.Order
            })
                .OrderBy(brand => brand.Order)
                .ToList();
        }
    }
}
