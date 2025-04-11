using System;
using System.Collections.Generic;
using UzumMarket.Models;
using UzumMarket.Models.Roles;
using UzumMarket.Services.IServices;

namespace UzumMarket.Services
{
    public class OrderService : IOrderService
    {
        public static List<Order> Orders = new List<Order>();
        public string AddOrder()
        {
            Console.Clear();
            Console.WriteLine("\nWelcome to the Order Service!\n");

            List<Product> products = ProductService.Products;
            List<Customer> customers = CustomerService.Customers;

            if (products.Count <= 0)
            {
                return "No products available";
            }

            if (customers.Count <= 0)
            {
                return "No customers available";
            }

            Console.WriteLine("---------------- Available Products -----------------------\n");

            foreach (var item in products)
            {
                Console.WriteLine
                (
                    $" Id: {item.Id},\n" +
                    $" Name: {item.Name},\n" +
                    $" Description: {item.Description},\n" +
                    $" Price: {item.Price},\n" +
                    $" Count: {item.Count},\n" +
                    $" Category: {item.Category},\n" +
                    $" Factory: {item.FactoryName},\n" +
                    $" Made Date: {item.MadeDate},\n" +
                    $" Expire Date: {item.ExpireDate}\n"
                );
            }

            Console.WriteLine("---------------- Available Customers -----------------------\n");

            foreach (var c in customers)
            {
                Console.WriteLine
                (
                    $" ID: " +
                    $"{c.Id}, " +
                    $"Name: {c.FirstName} {c.LastName}, " +
                    $"Balance: {c.Balance}"
                );
            }

            Order order = new Order();
            order.Id = Guid.NewGuid();

            try
            {
                Console.WriteLine("\nEnter Your ID:");
                string customerIdInput = Console.ReadLine();
                if (!Guid.TryParse(customerIdInput, out Guid customerId))
                {
                    return "Invalid your ID format";
                }

                Customer customer = customers.Find(c => c.Id == customerId);
                if (customer == null)
                {
                    return "You are not found";
                }

                Console.WriteLine("\nEnter Product ID:");
                string productIdInput = Console.ReadLine();
                if (!Guid.TryParse(productIdInput, out Guid productId))
                {
                    return "Invalid product ID format";
                }

                Product product = products.Find(p => p.Id == productId);
                if (product == null)
                {
                    return "Product not found";
                }

                if (product.ExpireDate <= DateTime.Now)
                {
                    return "Product is expired";
                }

                if (product.Count <= 0)
                {
                    return "Product is out of stock";
                }

                Console.WriteLine("\nEnter Quantity:");
                string quantityInput = Console.ReadLine();
                if (!int.TryParse(quantityInput, out int quantity) || quantity <= 0)
                {
                    return "Invalid quantity";
                }

                if (quantity > product.Count)
                {
                    return $"\nNot enough stock. Available: {product.Count}, Requested: {quantity}";
                }

                decimal totalPrice = product.Price * quantity;

                if (totalPrice > customer.Balance)
                {
                    return $"\nInsufficient balance. Your balance: {customer.Balance}, required: {totalPrice}";
                }

                Console.WriteLine("Enter Shipping Address:");
                string shippingAddress = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(shippingAddress))
                {
                    return "Invalid shipping address";
                }

                order.ProductId = product.Id;
                order.Quantity = quantity;
                order.ShippingAddress = shippingAddress;
                order.OrderDate = DateTime.Now;
                order.Status = "Pending";
                order.PaymentStatus = "Unpaid";

                product.Count -= quantity;
                customer.Balance -= totalPrice;

                Orders.Add(order);

                return $"\nOrder added successfully!\n\nRemaining Balance: {customer.Balance}";
            }
            catch (Exception ex)
            {
                return $"Error adding order: {ex.Message}";
            }
        }

        /* ---------------- DeleteOrder------------------ */



        public string DeleteOrder(Guid Id)
        {
            Order order = Orders.Find(o => o.Id == Id);
            if (order != null)
            {
                Orders.Remove(order);
                return "Order deleted successfully";
            }
            else
            {
                return "Order not found";
            }
        }

        public List<Order> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public Order GetOrderById(Guid Id)
        {
            throw new NotImplementedException();
        }
    }
}
