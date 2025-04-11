using System;
using System.Collections.Generic;
using UzumMarket.Models;

namespace UzumMarket.Services.IServices
{
    public interface IProductService
    {
        public string AddProduct(Product product);
        public string UpdateProduct(Product product);
        public string DeleteProduct(Guid Id);
        public Product GetProductById(Guid Id);
        public List<Product> GetAllProducts();
        public List<Product> GetProductsByCategory(string category);
        public List<Product> GetProductsByFactory(string factoryName);

    }
}