using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.DomainEntities.Entities.Base;
using WebStore.DomainEntities.Entities.Base.Interfaces;

namespace WebStore.DomainEntities.Entities
{
    public class Product : BaseEntity, IOrderedEntity
    {
        public int Order { get; set; }
        /// <summary>
        /// Секция, к которой принадлежит продукт
        /// </summary>
        public int SectionId { get; set; }

        [ForeignKey("SectionId")]
        public virtual Section Section { get; set; }

        public int? BrandId { get; set; }

        [ForeignKey("BrandId")]
        public virtual Brand Brand { get; set; }

        public string ImageUrl { get; set; }
       
        public decimal Price { get; set; }
    }
}
