using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Microsoft.Extensions.Configuration;
using WebStore.Clients.Base;
using WebStore.DomainEntities.DTO.Order;
using WebStore.DomainEntities.Entities;
using WebStore.Interfaces.Services;

namespace WebStore.Clients.Orders
{
    public class OrdersClient : BaseClient, IOrderService
    {
        public OrdersClient(IConfiguration configuration) : base(configuration)
        {
            ServiceAddress = "api/orders";
        }

        public OrderDTO CreateOrder(CreateOrderModel model, string UserName)
        {
            var response = Post($"{ServiceAddress}/{UserName}", model);
            return response.Content.ReadAsAsync<OrderDTO>().Result;
        }

        public OrderDTO GetOrderById(int id)
        {
            return Get<OrderDTO>($"{ServiceAddress}/{id}");
        }

        public IEnumerable<OrderDTO> GetUserOrders(string UserName)
        {
            return Get<List<OrderDTO>>($"{ServiceAddress}/user/{UserName}");
        }
    }
}
