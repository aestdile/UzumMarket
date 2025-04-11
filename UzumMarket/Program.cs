using System;
using UzumMarket.Models.Roles;
using UzumMarket.Services;
using UzumMarket.Services.IServices;
namespace UzumMarket
{
    class Program
    {
        static void Main(string[] args)
        {
        start:
            Console.WriteLine("---------------- Welcome to UzumMarket! ----------------\n");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. Manager");
            Console.WriteLine("2. Seller");
            Console.WriteLine("3. Customer");
            Console.WriteLine("4. Exit\n");
            string role = Console.ReadLine();
            Console.WriteLine();


            /* ---------------- Manager Role ------------------ */

            if (role == "1")
            {
                ManagerService manageService = new ManagerService();
                Console.WriteLine("Please select an option:\n");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit\n");
                string action = Console.ReadLine();
                Console.WriteLine();
                if (action == "1")
                {
                    Console.WriteLine(manageService.Register(new Manager()));
                    Console.WriteLine();
                    Console.WriteLine(manageService.Management());
                }
                else if (action == "2")
                {
                    Console.WriteLine(manageService.Login());
                    Console.WriteLine();
                    Console.WriteLine(manageService.Management());
                }
                else if (action == "3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    goto start;
                }
            }


            /* -------------- Seller Management ------------------- */

            if (role == "2")
            {
                SellerService sellerService = new SellerService();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit\n");
                string action = Console.ReadLine();
                if (action == "1")
                {
                    Console.WriteLine(sellerService.Register(new Seller()));
                    Console.WriteLine();
                    Console.WriteLine(sellerService.ManageProducts());

                    Console.Clear();
                    Console.Write("\nDo you want to continue as a Customer? (yes/no): ");
                    Console.Clear();
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "yes" || choice == "y" || choice == "Y")
                    {
                        role = "3";
                        goto customerRole;
                    }
                    else
                    {
                        goto start;
                    }
                }
                else if (action == "2")
                {
                    Console.WriteLine(sellerService.Login());
                    Console.WriteLine();
                    Console.WriteLine(sellerService.ManageProducts());

                    Console.Clear();
                    Console.Write("\nDo you want to continue as a Customer? (yes/no) (Y/y): ");
                    Console.WriteLine();
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "yes" || choice == "y" || choice == "Y")
                    {
                        role = "3";
                        goto customerRole;
                    }
                    else
                    {
                        goto start;
                    }
                }
                else if (action == "3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    goto start;
                }
            }


        /* ---------------- Customer Role ------------------ */

        customerRole:
            if (role == "3")
            {
                CustomerService customerService = new CustomerService();
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                string action = Console.ReadLine();
                if (action == "1")
                {
                    Console.WriteLine(customerService.Register(new Customer()));
                    Console.WriteLine();
                    Console.WriteLine(customerService.ManageOrders());

                    Console.Clear();
                    Console.Write("\nDo you want to continue as a Seller? (yes/no): ");
                    Console.WriteLine();
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "yes" || choice == "y" || choice == "Y")
                    {
                        role = "2";
                        goto sellerRole;
                    }
                    else
                    {
                        goto start;
                    }
                }
                else if (action == "2")
                {
                    Console.WriteLine(customerService.Login());
                    Console.WriteLine();
                    Console.WriteLine(customerService.ManageOrders());

                    Console.Clear();
                    Console.Write("\nDo you want to continue as a Seller? (yes/no): ");
                    Console.WriteLine();
                    string choice = Console.ReadLine().ToLower();
                    if (choice == "yes" || choice == "y" || choice == "Y")
                    {
                        role = "2";
                        goto sellerRole;
                    }
                    else
                    {
                        goto start;
                    }
                }
                else if (action == "3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Invalid option. Please try again.");
                    goto start;
                }
            }


            /* ---------------- Exit ------------------ */

            else if (role == "4")
            {
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Invalid option. Please try again.");
                goto start;
            }


        sellerRole:
            role = "2";
            goto start;
        }
    }
}