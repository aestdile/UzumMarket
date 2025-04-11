using System.Collections.Generic;
using UzumMarket.Models.Roles;

namespace UzumMarket.Services.IServices
{
    public interface ISellerService
    {
        public string Register(Seller seller);
        public string Login();
        public string ManageProducts();
        public List<Seller> GetAllSellers();
    }
}