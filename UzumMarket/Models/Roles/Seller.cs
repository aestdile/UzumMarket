
using System;

namespace UzumMarket.Models.Roles
{
    public class Seller
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; } = 5000000;
    }
}