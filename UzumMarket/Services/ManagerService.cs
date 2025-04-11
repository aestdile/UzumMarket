using System;
using System.Collections.Generic;
using System.Linq;
using UzumMarket.Models.Roles;
using UzumMarket.Services.IServices;

namespace UzumMarket.Services
{
    public class ManagerService : IManagerService
    {
        public static List<Manager> Managers = new List<Manager>();


        /* -------------------- Management --------------------- */

        public string Management()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the management system!\n");
            while (true)
            {
                Console.WriteLine("Please choose an option:\n");
                Console.WriteLine("1. Manage Sellers");
                Console.WriteLine("2. Manage Customers");
                Console.WriteLine("3. Manage Products");
                Console.WriteLine("4. Manage Orders");
                Console.WriteLine("5. Exit\n");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ManageSeller();
                        break;
                    case "2":
                        ManageCustomer();
                        break;
                    case "3":
                        ManageProduct();
                        break;
                    case "4":
                        ManageOrder();
                        break;
                    case "5":
                        return "Exiting management system...";
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }

                return "\nManagement is successful\n";
            }
        }


        /* -------------------- Seller Management --------------------- */

        public string ManageSeller()
        {
            Console.Clear();

            /* -------------- All Sellers ---------------- */

            while (true)
            {
                Console.WriteLine("1. GetAllSellers");
                Console.WriteLine("2. UpdateSalaryOfSellers");
                Console.WriteLine("3. UpdatePositionOfSellers");
                Console.WriteLine("4. DeleteSellers");
                Console.WriteLine("5. Exit\n");
                Console.WriteLine("Choice an option (1 / 2 / 3 / 4): ");
                Console.WriteLine();
                string action = Console.ReadLine();

                switch (action)
                {
                    case "1":
                        GetAllSellers();
                        break;
                    case "2":
                        UpdateSalaryOfSellers();
                        break;
                    case "3":
                        UpdatePositionOfSellers();
                        break;
                    case "4":
                        DeleteSeller();
                        break;
                    case "5":
                        return "Exiting seller management...";
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }

            return "SellerManagement is successful";
        }



        /* -------------------- Get All Sellers --------------------- */

        public string GetAllSellers()
        {


            List<Seller> sellers = SellerService.Sellers;
            if (sellers.Count <= 0)
            {
                return "No sellers available";
            }

            Console.WriteLine("---------------- Available Sellers -----------------------");
            foreach (var item in sellers)
            {
                Console.WriteLine
                (
                    $" Id: {item.Id},\n" +
                    $" First Name: {item.FirstName},\n" +
                    $" Last Name: {item.LastName},\n" +
                    $" Password: {item.Password},\n" +
                    $" Email: {item.Email},\n" +
                    $" Position: {item.Position},\n" +
                    $" Salary: {item.Salary}"
                );
            }

            return "GetAllSeller management is successful\n";
        }



        /* -------------------- Update Position Of Sellers --------------------- */

        public string UpdateSalaryOfSellers()
        {
            List<Seller> sellers = SellerService.Sellers;
            if (sellers.Count <= 0)
            {
                return "No sellers available";
            }
            Console.WriteLine("---------------- Available Sellers -----------------------");
            foreach (var item in sellers)
            {
                Console.WriteLine
                (
                    $" Id: {item.Id},\n" +
                    $" First Name: {item.FirstName},\n" +
                    $" Last Name: {item.LastName},\n" +
                    $" Password: {item.Password},\n" +
                    $" Email: {item.Email},\n" +
                    $" Position: {item.Position},\n" +
                    $" Salary: {item.Salary}"
                );
            }

            Console.WriteLine("Enter the ID of the seller you want to UpdateSalary: ");
            string idInput = Console.ReadLine();
            Guid id;
            if (!Guid.TryParse(idInput, out id))
            {
                return "Invalid ID format";
            }

            Seller seller = sellers.FirstOrDefault(s => s.Id == id);
            if (seller == null)
            {
                return "Seller not found";
            }

            Console.WriteLine("Enter the new salary for the seller: ");
            string salaryInput = Console.ReadLine();
            decimal salary;
            if (!decimal.TryParse(salaryInput, out salary))
            {
                return "Invalid salary format";
            }
            if (salary < 0)
            {
                return "Salary cannot be negative";
            }
            seller.Salary = salary;

            return "UpdateSalaryOfSeller management is successful";
        }




        public string DeleteCustomers()
        {
            throw new NotImplementedException();
        }

        public string DeleteOrder()
        {
            throw new NotImplementedException();
        }

        public string DeleteProduct()
        {
            throw new NotImplementedException();
        }

        public string DeleteSeller()
        {
            throw new NotImplementedException();
        }

        public string GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public string GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public string GetAllProducts()
        {
            throw new NotImplementedException();
        }

        

        public string Login()
        {
            throw new NotImplementedException();
        }

        public string ManageCustomer()
        {
            throw new NotImplementedException();
        }

        

        public string ManageOrder()
        {
            throw new NotImplementedException();
        }

        public string ManageProduct()
        {
            throw new NotImplementedException();
        }

       

        public string Register(Manager manager)
        {
            throw new NotImplementedException();
        }

        public string UpdateOrder()
        {
            throw new NotImplementedException();
        }

        public string UpdateProduct()
        {
            throw new NotImplementedException();
        }

        
    }
}
