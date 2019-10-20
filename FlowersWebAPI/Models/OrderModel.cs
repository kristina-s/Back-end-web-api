using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class OrderModel
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string CreditCardNumber { get; set; }
    }
}
