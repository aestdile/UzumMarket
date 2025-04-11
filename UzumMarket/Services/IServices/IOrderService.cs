using System;
using System.Collections.Generic;
using UzumMarket.Models;


namespace UzumMarket.Services.IServices
{
    public interface IOrderService
    {
        public string AddOrder();
        public string DeleteOrder(Guid Id);
        public Order GetOrderById(Guid Id);
        public List<Order> GetAllOrders();
    }
}