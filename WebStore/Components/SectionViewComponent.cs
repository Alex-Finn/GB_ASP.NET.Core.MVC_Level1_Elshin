using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.Infrasructure.Interfaces;
using WebStore.Models;

namespace WebStore.Components
{
    public class SectionViewComponent : ViewComponent
    {
        private readonly IProductData _productData;

        public SectionViewComponent(IProductData productData)
        {
            _productData = productData;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sections = GetSections();
            return View(sections);
        }

        private List<SectionViewModel> GetSections()
        {
            var sections = _productData.GetSections();
            var parent = sections.Where(section => section.ParentId != null).ToArray();

            var parentSectionsViews = parent.Select(section => new SectionViewModel
            {
                Id = section.Id,
                Name = section.Name,
                Order = section.Order,
            }).ToList();

            foreach (var parentView in parentSectionsViews)
            {
                var childs = sections.Where(section => section.ParentId == parentView.Id).ToArray();
                foreach (var child in childs)
                
                    parentView.ChildSections.Add(new SectionViewModel
                    {
                        Id = child.Id,
                        Name = child.Name,
                        Order = child.Order,
                        ParentSection = parentView
                    });
                parentView.ChildSections.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));                
            }
            parentSectionsViews.Sort((a, b) => Comparer<int>.Default.Compare(a.Order, b.Order));
            return parentSectionsViews;
        }
    }
}
