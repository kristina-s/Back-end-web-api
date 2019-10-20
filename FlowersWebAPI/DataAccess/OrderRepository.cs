using DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    public class OrderRepository : IRepository<OrderDto>
    {
        private readonly AppDbContext _context;
        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public void Add(OrderDto entity)
        {
            _context.Orders.Add(entity);
            _context.SaveChanges();
        }

        public IEnumerable<OrderDto> GetAll()
        {
            return _context.Orders;
        }
    }
}
