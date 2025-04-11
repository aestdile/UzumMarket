using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzumMarket.Models
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Category { get; set; }
        public string FactoryName { get; set; }
        public DateTime MadeDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public bool IsExpired { get; set; }
    }
}