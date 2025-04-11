using System;

namespace UzumMarket.Models
{
    public class Order
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid ProductId { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; } = DateTime.Now;
        public string Status { get; set; } // Pending, Shipped, Delivered, Cancelled
        public string PaymentStatus { get; set; } // Unpaid, Paid
        public string ShippingAddress { get; set; }

    }
}