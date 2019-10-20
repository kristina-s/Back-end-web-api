using DataAccess;
using DataModels;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Services
{
    public class OrderService: IOrderService
    {
        private readonly IRepository<OrderDto> _orderRepository;
        public OrderService(IRepository<OrderDto> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public void Add(OrderModel model)
        {
            OrderDto orderForDb = new OrderDto()
            {
                FullName = model.FullName,
                Address = model.Address,
                City = model.City,
                CreditCardNumber = model.CreditCardNumber
            };
            _orderRepository.Add(orderForDb);
        }

        public IEnumerable<OrderModel> GetOrders()
        {
            return _orderRepository.GetAll()
                .Select(o =>
                new OrderModel()
                {
                    Address = o.Address,
                    Id = o.Id,
                    City = o.City,
                    FullName = o.FullName,
                    CreditCardNumber = o.CreditCardNumber
                });
        }
    }
}
