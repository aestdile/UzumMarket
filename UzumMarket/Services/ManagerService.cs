using System;
using System.Collections.Generic;
using System.Linq;
using UzumMarket.Models;
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


        /* -------------------- Delete Seller --------------------- */

        public string DeleteSeller()
        {
            List<Seller> sellers = SellerService.Sellers;
            if (sellers.Count <= 0)
            {
                return "No sellers available";
            }
            Console.WriteLine("---------------- Available Sellers -----------------------");
            foreach (Seller seller in sellers)
            {
                Console.WriteLine
                (
                    $" Id: {seller.Id},\n" +
                    $" First Name: {seller.FirstName},\n" +
                    $" Last Name: {seller.LastName},\n" +
                    $" Password: {seller.Password},\n" +
                    $" Email: {seller.Email},\n" +
                    $" Position: {seller.Position},\n" +
                    $" Salary: {seller.Salary}"
                );
            }

            Console.WriteLine("Enter the ID of the seller you want to delete: ");
            string idInput = Console.ReadLine();
            Guid id;
            if (!Guid.TryParse(idInput, out id))
            {
                return "Invalid ID format";
            }
            Seller sellerToDelete = sellers.FirstOrDefault(s => s.Id == id);
            if (sellerToDelete == null)
            {
                return "Seller not found";
            }
            sellers.Remove(sellerToDelete);
            Console.WriteLine($"Seller with ID {id} has been deleted successfully.");

            return "DeleteSeller management is successful";
        }



        /* ------------------- Management Customer ---------------------  */


        public string ManageCustomer()
        {
            while (true)
            {
                Console.WriteLine("1. GetAllCustomers");
                Console.WriteLine("2. DeleteCustomers");
                Console.WriteLine("3. Exit\n");
                Console.WriteLine("Choice an option (1 / 2 / 3): ");
                Console.WriteLine();
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        GetAllCustomers();
                        break;
                    case "2":
                        DeleteCustomers();
                        break;
                    case "3":
                        return "Exiting customer management...";
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }

            return "Customer management is successful";
        }




        /* ------------------- GetAllCustomers ---------------------- */


        public string GetAllCustomers()
        {

            List<Customer> customers = CustomerService.Customers;
            if (customers.Count <= 0)
            {
                return "No customers available";
            }
            Console.WriteLine("---------------- Available Customers -----------------------");
            foreach (var customer in customers)
            {
                Console.WriteLine
                (
                    $" Id: {customer.Id},\n" +
                    $" First Name: {customer.FirstName},\n" +
                    $" Last Name: {customer.LastName},\n"
                );
            }

            return "GetAllCustomers management is successful";
        }



        /* ------------------- DeleteCustomers ---------------------- */

        public string DeleteCustomers()
        {
            List<Customer> customers = CustomerService.Customers;
            if (customers.Count <= 0)
            {
                return "No customers available";
            }
            Console.WriteLine("---------------- Available Customers to Delete-----------------------");
            foreach (var customer in customers)
            {
                Console.WriteLine
                (
                    $" Id: {customer.Id},\n" +
                    $" First Name: {customer.FirstName},\n" +
                    $" Last Name: {customer.LastName},\n"
                );
            }

            Console.WriteLine("Enter the ID of the customer you want to delete: ");
            string idInput = Console.ReadLine();
            Guid id;
            if (!Guid.TryParse(idInput, out id))
            {
                return "Invalid ID format";
            }

            Customer customerToDelete = customers.FirstOrDefault(c => c.Id == id);
            if (customerToDelete == null)
            {
                return "Customer not found";
            }
            customers.Remove(customerToDelete);
            Console.WriteLine($"Customer with ID {id} has been deleted successfully.\n");

            return "DeleteCustomers management is successful";
        }



        /* ------------------ Manage Products --------------------  */

        public string ManageProduct()
        {
            while (true)
            {
                Console.WriteLine("1. GetAllProducts");
                Console.WriteLine("2. UpdateProduct");
                Console.WriteLine("3. DeleteProduct");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("Choice an option (1 / 2 / 3): ");
                Console.WriteLine();
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        GetAllProducts();
                        break;
                    case "2":
                        UpdateProduct();
                        break;
                    case "3":
                        DeleteProduct();
                        break;
                    case "4":
                        return "Exiting product management...";
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }

            return "Product management is successful";
        }


        /* ------------------- GetAllProducts ---------------------- */


        public string GetAllProducts()
        {

            List<Product> products = ProductService.Products;
            if (products.Count <= 0)
            {
                return "No products available";
            }
            Console.WriteLine("---------------- Available Products -----------------------");
            foreach (var product in products)
            {
                Console.WriteLine
                (
                    $" Id: {product.Id},\n" +
                    $" Name: {product.Name},\n" +
                    $" Description: {product.Description},\n" +
                    $" Price: {product.Price},\n" +
                    $" Category: {product.Category},\n" +
                    $" Factory: {product.FactoryName},\n" +
                    $" Made Date: {product.MadeDate},\n" +
                    $" Expire Date: {product.ExpireDate}"
                );
            }

            return "GetAllProducts management is successful";
        }


        /* ------------------- UpdateProducts ---------------------- */

        public string UpdateProduct()
        {
            List<Product> products = ProductService.Products;
            if (products.Count <= 0)
            {
                return "No products available";
            }
            Console.WriteLine("---------------- Available Products -----------------------");
            foreach (var product in products)
            {
                Console.WriteLine
                (
                    $" Id: {product.Id},\n" +
                    $" Name: {product.Name},\n" +
                    $" Description: {product.Description},\n" +
                    $" Price: {product.Price},\n" +
                    $" Category: {product.Category},\n" +
                    $" Factory: {product.FactoryName},\n" +
                    $" Made Date: {product.MadeDate},\n" +
                    $" Expire Date: {product.ExpireDate}"
                );
            }

            Console.WriteLine("Enter the ID of the product you want to update: ");
            string idInput = Console.ReadLine();
            Guid id;
            if (!Guid.TryParse(idInput, out id))
            {
                return "Invalid ID format";
            }

            Product productToUpdate = products.FirstOrDefault(p => p.Id == id);
            if (productToUpdate == null)
            {
                return "Product not found";
            }

            Console.WriteLine("Enter the new name for the product: ");
            string newName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(newName))
                {
                    return "Name cannot be empty";
                }
                else if (newName.Length < 3 || newName.Length > 20)
                {
                    return "Name must be between 3 and 20 characters";
                }
                else if (!char.IsUpper(newName[0]))
                {
                    return "Name must start with an uppercase letter";
                }
                else if (newName.Any(char.IsDigit))
                {
                    return "Name cannot contain numbers";
                }
                else if (newName.Any(char.IsSymbol))
                {
                    return "Name cannot contain symbols";
                }
                else
                {
                    break;
                }
                Console.WriteLine("Please, enter again! Name: ");
                newName = Console.ReadLine();
            }
            productToUpdate.Name = newName;

            Console.WriteLine("Enter the new description for the product: ");
            string newDescription = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(newDescription))
                {
                    return "Description cannot be empty";
                }
                else if (newDescription.Length < 3 || newDescription.Length > 20)
                {
                    return "Description must be between 3 and 20 characters";
                }
                else if (!char.IsUpper(newDescription[0]))
                {
                    return "Description must start with an uppercase letter";
                }
                else if (newDescription.Any(char.IsDigit))
                {
                    return "Description cannot contain numbers";
                }
                else if (newDescription.Any(char.IsSymbol))
                {
                    return "Description cannot contain symbols";
                }
                else
                {
                    break;
                }
                Console.WriteLine("Please, enter again! Description: ");
                newDescription = Console.ReadLine();
            }
            productToUpdate.Description = newDescription;

            Console.WriteLine("Enter the new price for the product: ");
            string priceInput = Console.ReadLine();
            decimal price;
            if (!decimal.TryParse(priceInput, out price))
            {
                return "Invalid price format";
            }
            if (price < 0)
            {
                return "Price cannot be negative";
            }
            productToUpdate.Price = price;

            Console.WriteLine("Enter the new category for the product: ");
            string newCategory = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(newCategory))
                {
                    return "Category cannot be empty";
                }
                else if (newCategory.Length < 3 || newCategory.Length > 20)
                {
                    return "Category must be between 3 and 20 characters";
                }
                else if (!char.IsUpper(newCategory[0]))
                {
                    return "Category must start with an uppercase letter";
                }
                else if (newCategory.Any(char.IsDigit))
                {
                    return "Category cannot contain numbers";
                }
                else if (newCategory.Any(char.IsSymbol))
                {
                    return "Category cannot contain symbols";
                }
                else
                {
                    break;
                }
                Console.WriteLine("Please, enter again! Category: ");
                newCategory = Console.ReadLine();
            }
            productToUpdate.Category = newCategory;


            Console.WriteLine("Enter the new factory name for the product: ");
            string newFactoryName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(newFactoryName))
                {
                    return "Factory name cannot be empty";
                }
                else if (newFactoryName.Length < 3 || newFactoryName.Length > 20)
                {
                    return "Factory name must be between 3 and 20 characters";
                }
                else if (!char.IsUpper(newFactoryName[0]))
                {
                    return "Factory name must start with an uppercase letter";
                }
                else if (newFactoryName.Any(char.IsDigit))
                {
                    return "Factory name cannot contain numbers";
                }
                else if (newFactoryName.Any(char.IsSymbol))
                {
                    return "Factory name cannot contain symbols";
                }
                else
                {
                    break;
                }
                Console.WriteLine("Please, enter again! Factory Name: ");
                newFactoryName = Console.ReadLine();
            }
            productToUpdate.FactoryName = newFactoryName;


            Console.WriteLine("Enter the new made date for the product (yyyy-mm-dd): ");
            string madeDateInput = Console.ReadLine();
            DateTime madeDate;
            if (!DateTime.TryParse(madeDateInput, out madeDate))
            {
                return "Invalid made date format";
            }
            if (madeDate > DateTime.Now)
            {
                return "Made date cannot be in the future";
            }
            productToUpdate.MadeDate = madeDate;


            Console.WriteLine("Enter the new expire date for the product (yyyy-mm-dd): ");
            string expireDateInput = Console.ReadLine();
            DateTime expireDate;
            if (!DateTime.TryParse(expireDateInput, out expireDate))
            {
                return "Invalid expire date format";
            }
            if (expireDate < DateTime.Now)
            {
                return "Expire date cannot be in the past";
            }
            productToUpdate.ExpireDate = expireDate;
            productToUpdate.IsExpired = expireDate < DateTime.Now;
            if (productToUpdate.IsExpired)
            {
                return "Product is expired";
            }
            Console.WriteLine("Enter the new count for the product: ");
            string countInput = Console.ReadLine();
            int count;
            if (!int.TryParse(countInput, out count))
            {
                return "Invalid count format";
            }
            if (count < 0)
            {
                return "Count cannot be negative";
            }
            productToUpdate.Count = count;
            Console.WriteLine("Product updated successfully!");

            return "UpdateProduct management is successful";
        }


        /* ------------------- DeleteProducts ---------------------- */

        public string DeleteProduct()
        {
            List<Product> products = ProductService.Products;
            if (products.Count <= 0)
            {
                return "No products available";
            }
            Console.WriteLine("---------------- Available Products -----------------------");
            foreach (var product in products)
            {
                Console.WriteLine
                (
                    $" Id: {product.Id},\n" +
                    $" Name: {product.Name},\n" +
                    $" Description: {product.Description},\n" +
                    $" Price: {product.Price},\n" +
                    $" Category: {product.Category},\n" +
                    $" Factory: {product.FactoryName},\n" +
                    $" Made Date: {product.MadeDate},\n" +
                    $" Expire Date: {product.ExpireDate}"
                );
            }

            Console.WriteLine("Enter the ID of the product you want to delete: ");
            string idInput = Console.ReadLine();
            Guid id;
            if (!Guid.TryParse(idInput, out id))
            {
                return "Invalid ID format";
            }

            Product productToDelete = products.FirstOrDefault(p => p.Id == id);
            if (productToDelete == null)
            {
                return "Product not found";
            }
            if (productToDelete.IsExpired)
            {
                return "Product is expired and cannot be deleted";
            }
            products.Remove(productToDelete);
            Console.WriteLine($"Product with ID {id} has been deleted successfully.");
            Console.WriteLine("Product deleted successfully!");


            return "DeleteProduct management is successful";
        }


        /* ------------------- Manage Orders ---------------------- */

        public string ManageOrder()
        {
            while (true)
            {
                Console.WriteLine("1. GetAllOrders");
                Console.WriteLine("2. UpdateOrder");
                Console.WriteLine("3. DeleteOrder");
                Console.WriteLine("4. Exit\n");
                Console.WriteLine("Choice an option (1 / 2 / 3): ");
                Console.WriteLine();
                string action = Console.ReadLine();
                switch (action)
                {
                    case "1":
                        GetAllOrders();
                        break;
                    case "2":
                        UpdateOrder();
                        break;
                    case "3":
                        DeleteOrder();
                        break;
                    case "4":
                        return "Exiting order management...";
                    default:
                        Console.WriteLine("Invalid choice, please try again.");
                        break;
                }
            }
            return "Order management is successful";
        }


        public string DeleteOrder()
        {
            throw new NotImplementedException();
        }

        

       
        public string GetAllOrders()
        {
            throw new NotImplementedException();
        }

       
        

        public string Login()
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

      
        
    }
}
