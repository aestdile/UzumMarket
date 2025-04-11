
using UzumMarket.Models.Roles;

namespace UzumMarket.Services.IServices
{
    public interface IManagerService
    {
        public string Management();
        public string ManageSeller();
        public string GetAllSellers();
        public string UpdateSalaryOfSellers();
        public string DeleteSeller();
        public string ManageCustomer();
        public string GetAllCustomers();
        public string DeleteCustomers();
        public string ManageProduct();
        public string GetAllProducts();
        public string UpdateProduct();
        public string DeleteProduct();
        public string ManageOrder();
        public string GetAllOrders();
        public string UpdateOrder();
        public string DeleteOrder();
        public string Register(Manager manager);
        public string Login();
    }
}