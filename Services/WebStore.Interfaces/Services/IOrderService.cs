using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebStore.DomainEntities.DTO.Order;
using WebStore.DomainEntities.Entities;
using WebStore.DomainEntities.ViewModels;
using WebStore.Models;

namespace WebStore.Interfaces.Services
{
    public interface IOrderService
    {
        IEnumerable<OrderDTO> GetUserOrders(string UserName);

        OrderDTO GetOrderById(int id);

        OrderDTO CreateOrder(CreateOrderModel model, string UserName);
    }
}
