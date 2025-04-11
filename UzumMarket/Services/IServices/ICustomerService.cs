using System.Collections.Generic;
using UzumMarket.Models.Roles;

namespace UzumMarket.Services.IServices
{
    public interface ICustomerService
    {
        public string Register(Customer customer);
        public string Login();
        public string ManageOrders();
        public List<Customer> GetAllCustomers();
        public string Deposit();
    }
}