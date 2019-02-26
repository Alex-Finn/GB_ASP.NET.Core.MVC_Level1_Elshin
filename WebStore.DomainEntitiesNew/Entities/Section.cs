using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebStore.DomainEntities.Entities.Base;
using WebStore.DomainEntities.Entities.Base.Interfaces;

namespace WebStore.DomainEntities.Entities
{
    /// <summary>
    /// Секция товаров. Категория
    /// </summary>
    [Table("Sections")]
    public class Section : NamedEntity, IOrderedEntity
    {
        /// <summary>
        /// Родительская секция. Необязательное свойство
        /// </summary>
        public int? ParentId { get; set; }

        [ForeignKey(nameof(ParentId))]
        public virtual Section ParentSection { get; set; }

        /// <summary>
        /// Порядок
        /// </summary>
        public int Order { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}