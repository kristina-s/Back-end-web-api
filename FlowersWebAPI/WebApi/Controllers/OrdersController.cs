using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        // GET: api/Orders
        [HttpGet]
        public IEnumerable<OrderModel> Get()
        {
            return _orderService.GetOrders();
        }

        // POST: api/Orders
        [HttpPost]
        public void Post([FromBody] OrderModel order)
        {
            _orderService.Add(order);
        }

    }
}
