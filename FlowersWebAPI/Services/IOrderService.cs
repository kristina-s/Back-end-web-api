using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface IOrderService
    {
        IEnumerable<OrderModel> GetOrders();
        void Add(OrderModel model);
    }
}
