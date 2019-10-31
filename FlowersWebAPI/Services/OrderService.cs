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
        private readonly IRepository<UserDto> _userRepository;
        public OrderService(IRepository<OrderDto> orderRepository, IRepository<UserDto> userRepository)
        {
            _orderRepository = orderRepository;
            _userRepository = userRepository;
        }

        public void Add(OrderModel model)
        {
            var user = _userRepository.GetAll()
                .FirstOrDefault(x => x.Id == model.UserId);

            if (user == null)
                throw new Exception("User was not found");

            OrderDto orderForDb = new OrderDto()
            {
                UserId = model.UserId,
                FullName = model.FullName,
                Address = model.Address,
                City = model.City,
                CreditCardNumber = model.CreditCardNumber
            };
            _orderRepository.Add(orderForDb);
        }

        public IEnumerable<OrderModel> GetOrders(int userId)
        {
            return _orderRepository.GetAll()
                .Where(x => x.UserId == userId)
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
