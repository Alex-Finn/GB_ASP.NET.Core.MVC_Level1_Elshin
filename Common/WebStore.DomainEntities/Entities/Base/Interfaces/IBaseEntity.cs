using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebStore.DomainEntities.Entities.Base.Interfaces
{
    /// <summary>
    /// Сущность с идентификатором
    /// </summary>
    public interface IBaseEntity
    {
        /// <summary>
        /// Идентификатор сушности
        /// </summary>
        int Id { get; set; }
    }
}
