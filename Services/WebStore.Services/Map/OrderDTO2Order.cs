using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WebStore.DomainEntities.DTO.Order;
using WebStore.DomainEntities.Entities;

namespace WebStore.Services.Map
{
    public static class OrderDTO2Order
    {
        public static OrderDTO Map(this Order order)
        {
            return new OrderDTO
            {
                Id = order.Id,
                Name = order.Name,
                Phone = order.Phone,
                Address = order.Address,
                Date = order.Date,
                Items = order.OrderItems?.Select(item => new OrderItemDTO
                {
                    Id = item.Id,
                    Price = item.Price,
                    Quantity = item.Count
                })
            };
        }
    }
}
