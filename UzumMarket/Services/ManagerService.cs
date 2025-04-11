﻿using System;
using System.Collections.Generic;
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

        public string GetAllSellers()
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

        public string ManageSeller()
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

        public string UpdateSalaryOfSellers()
        {
            throw new NotImplementedException();
        }
    }
}
