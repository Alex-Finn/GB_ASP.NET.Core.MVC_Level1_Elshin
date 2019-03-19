using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebStore.DomainEntities.DTO.Order;
using WebStore.DomainEntities.Entities;
using WebStore.Interfaces.Services;

namespace WebStore.ServiceHosting.Controllers
{    
    [ApiController, Route("api/[controller]"), Produces("application/json")]
    public class OrdersController : ControllerBase, IOrderService
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("{UserName?}")]
        public OrderDTO CreateOrder([FromBody] CreateOrderModel model, string UserName)
        {
            return _orderService.CreateOrder(model, UserName);
        }

        [HttpGet("{id}"), ActionName("Get")]
        public OrderDTO GetOrderById(int id)
        {
            return _orderService.GetOrderById(id);
        }

        [HttpGet("user/{UserName}")]
        public IEnumerable<OrderDTO> GetUserOrders(string UserName)
        {
            return _orderService.GetUserOrders(UserName);
        }
    }
}