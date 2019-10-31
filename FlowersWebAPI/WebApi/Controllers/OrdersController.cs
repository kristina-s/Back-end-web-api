using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace WebApi.Controllers
{
    [Authorize]
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
            var userId = GetAuthorizedUserId();
            return _orderService.GetOrders(userId);
        }

        // POST: api/Orders
        [HttpPost]
        public IActionResult Post([FromBody] OrderModel order)
        {
            order.UserId = GetAuthorizedUserId();
            _orderService.Add(order);
            return Ok(order);
        }

        private int GetAuthorizedUserId()
        {
            if (!int.TryParse(User
                .FindFirst(ClaimTypes.NameIdentifier)?.Value,
                out var userId))
            {
                throw new Exception("Name identifier claim does not exist.");
            }
            return userId;
        }

    }
}
