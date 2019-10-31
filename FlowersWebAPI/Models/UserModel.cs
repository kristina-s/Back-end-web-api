﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Token { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public List<OrderModel> OrderList { get; set; } =
            new List<OrderModel>();
    }
}
