using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using UzumMarket.Models;
using UzumMarket.Services.IServices;

namespace UzumMarket.Services
{
    public class ProductService : IProductService
    {
        public static List<Product> Products { get; set; } = new List<Product>();
        public string AddProduct(Product product)
        {
            /* --------------- Product Name ---------------- */

            Console.Write("Product Name: ");
            string productName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(productName))
                {
                    Console.WriteLine("Product Name can not be empty!");
                }
                else if (productName.Length > 20)
                {
                    Console.WriteLine("Product Name can not be more than 20 characters!");
                }
                else if (productName.Length < 3)
                {
                    Console.WriteLine("Product Name can not be less than 3 characters!");
                }
                else if (!char.IsUpper(productName[0]))
                {
                    Console.WriteLine("Product Name start with an uppercase letter!");
                }
                else
                {
                    product.Name = productName;
                    break;
                }
                Console.WriteLine("Please enter again! Product Name: ");
                productName = Console.ReadLine();
            }


            /* --------------- Product Description ---------------- */

            Console.Write("Product Description: ");
            string productDescription = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(productDescription))
                {
                    Console.WriteLine("Product Description can not be empty!");
                }
                else if (productDescription.Length < 20)
                {
                    Console.WriteLine("Product Description can not be less than 20 characters!");
                }
                else if (productDescription.Length > 200)
                {
                    Console.WriteLine("Product Description can not be more than 200 characters!");
                }
                else if (!char.IsUpper(productDescription[0]))
                {
                    Console.WriteLine("Product Description start with an upper letter!");
                }
                else
                {
                    product.Description = productDescription;
                    break;
                }
                Console.WriteLine("Please enter again! Product Description: ");
                productDescription = Console.ReadLine();
            }


            /* --------------- Product Price ---------------- */

            Console.Write("Product Price: ");
            string price = Console.ReadLine();
            while (true)
            {
                decimal productPrice;
                if (decimal.TryParse(price, NumberStyles.Any, CultureInfo.InvariantCulture, out productPrice))
                {
                    product.Price = productPrice;
                    break;
                }
                Console.WriteLine("Please enter again! Product Price: ");
                price = Console.ReadLine();
            }


            /* --------------- Product Count ---------------- */

            Console.Write("Product Count: ");
            string count = Console.ReadLine();
            while (true)
            {
                int productCount;
                if (int.TryParse(count, NumberStyles.Any, CultureInfo.InvariantCulture, out productCount))
                {
                    product.Count = productCount;
                    break;
                }
                else if (!count.All(c => char.IsNumber(c)))
                {
                    Console.WriteLine("Product Count must contain only numbers!");
                }
                else
                {
                    Console.WriteLine("Invalid count! Plea, enter again!");
                    count = Console.ReadLine();
                }
                Console.WriteLine("Please enter again! Product Count: ");
                count = Console.ReadLine();
            }


            /* --------------- Product Category ---------------- */

            Console.Write("Product Category: ");
            string productCategory = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(productCategory))
                {
                    Console.WriteLine("Product Category can not be empty!");
                }
                else if (productCategory.Length < 3)
                {
                    Console.WriteLine("Product Category can not be less than 3 characters");
                }
                else if (productCategory.Length > 30)
                {
                    Console.WriteLine("Product Category can not be more than 30 characters!");
                }
                else if (!char.IsUpper(productCategory[0]))
                {
                    Console.WriteLine("Product Category start with an upper letter!");
                }
                else if (!productCategory.All(c => char.IsLetter(c)))
                {
                    Console.WriteLine("Product Category must contain only letters!");
                }
                else
                {
                    product.Category = productCategory;
                    break;
                }
                Console.WriteLine("Please enter again! Product Category: ");
                productCategory = Console.ReadLine();
            }


            /* --------------- Product Factory Name ---------------- */

            Console.Write("Product Factory Name: ");
            string factoryName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(factoryName))
                {
                    Console.WriteLine("Factory Name can not be empty!");
                }
                else if (factoryName.Length < 3)
                {
                    Console.WriteLine("Factory Name can not be less than 3 characters");
                }
                else if (factoryName.Length > 30)
                {
                    Console.WriteLine("Factory Name can not be more than 30 characters!");
                }
                else if (!char.IsUpper(factoryName[0]))
                {
                    Console.WriteLine("Factory Name start with an upper letter!");
                }
                else if (!factoryName.All(c => char.IsLetter(c)))
                {
                    Console.WriteLine("Factory Name must contain only letters!");
                }
                else
                {
                    product.FactoryName = factoryName;
                    break;
                }
                Console.WriteLine("Please enter again! Product Factory Name: ");
                factoryName = Console.ReadLine();
            }



            /* --------------- Product Made Date ---------------- */


            Console.WriteLine("Product Made Date (yyyy-mm-dd): ");
            int yil, oy, kun;

            Console.Write("Product Made Year: ");
            string year = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(year, NumberStyles.Any, CultureInfo.InvariantCulture, out yil))
                    break;

                Console.WriteLine("Invalid year! Please enter again. Product Made Year: ");
                year = Console.ReadLine();
            }

            Console.Write("Product Made Month (1 - 12): ");
            string month = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(month, NumberStyles.Any, CultureInfo.InvariantCulture, out oy) && oy >= 1 && oy <= 12)
                    break;

                Console.WriteLine("Invalid month! Please enter again. Product Made Month: ");
                month = Console.ReadLine();
            }

            Console.Write("Product Made Day (1 - 31): ");
            string day = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(day, NumberStyles.Any, CultureInfo.InvariantCulture, out kun) && kun >= 1 && kun <= 31)
                    break;

                Console.WriteLine("Invalid day! Please enter again. Product Made Day: ");
                day = Console.ReadLine();
            }
            product.MadeDate = new DateTime(yil, oy, kun);


            /* --------------- Product Expire Date ---------------- */

            Console.WriteLine("Product Expire Date (yyyy-mm-dd): ");
            int expYil, expOy, expKun;

            Console.Write("Product Expire Year: ");
            string expYear = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(expYear, NumberStyles.Any, CultureInfo.InvariantCulture, out expYil))
                    break;

                Console.WriteLine("Invalid year! Please enter again. Product Expire Year: ");
                expYear = Console.ReadLine();
            }

            Console.Write("Product Expire Month (1 - 12): ");
            string expMonth = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(expMonth, NumberStyles.Any, CultureInfo.InvariantCulture, out expOy) && expOy >= 1 && expOy <= 12)
                    break;

                Console.WriteLine("Invalid month! Please enter again. Product Expire Month: ");
                expMonth = Console.ReadLine();
            }

            Console.Write("Product Expire Day (1 - 31): ");
            string expDay = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(expDay, NumberStyles.Any, CultureInfo.InvariantCulture, out expKun) && expKun >= 1 && expKun <= 31)
                    break;

                Console.WriteLine("Invalid day! Please enter again. Product Expire Day: ");
                expDay = Console.ReadLine();
            }
            product.ExpireDate = new DateTime(expYil, expOy, expKun);


            Products.Add(product);
            return "\nProduct is succesfully added!";
        }



        /* ----------------- Get All Products --------------------  */


        public List<Product> GetAllProducts()
        {
            if (Products.Count <= 0)
            {
                return null;
            }

            DateTime today = DateTime.Now;
            foreach (var product in Products)
            {
                if (product.ExpireDate < today)
                {
                    Console.WriteLine($"{product.Name} is expired! ");
                    product.IsExpired = true;
                }
                else
                {
                    Console.WriteLine($"{product.Name} is valid!");
                    product.IsExpired = false;
                }
            }
            Console.WriteLine();
            return Products;
        }


        /* --------------- Update Product ---------------- */

        public string UpdateProduct(Product product)
        {
            Product product1 = Products.FirstOrDefault(p => p.Id == product.Id);
            if (product1 != null)
            {
                /* --------------- Product Name ---------------- */


                Console.Write("Product Name: ");
                string productName = Console.ReadLine();
                while (true)
                {
                    if (string.IsNullOrWhiteSpace(productName))
                    {
                        Console.WriteLine("Product Name can not be empty!");
                    }
                    else if (productName.Length > 20)
                    {
                        Console.WriteLine("Product Name can not be more than 20 characters!");
                    }
                    else if (productName.Length < 3)
                    {
                        Console.WriteLine("Product Name can not be less than 3 characters!");
                    }
                    else if (!char.IsUpper(productName[0]))
                    {
                        Console.WriteLine("Product Name start with an uppercase letter!");
                    }
                    else
                    {
                        product1.Name = productName;
                        break;
                    }
                    Console.WriteLine("Please enter again! Product Name: ");
                    productName = Console.ReadLine();
                }

                /* --------------- Product Description ---------------- */


                Console.Write("Product Description: ");
                string productDescription = Console.ReadLine();
                while (true)
                {
                    if (string.IsNullOrWhiteSpace(productDescription))
                    {
                        Console.WriteLine("Product Description can not be empty!");
                    }
                    else if (productDescription.Length < 20)
                    {
                        Console.WriteLine("Product Description can not be less than 20 characters!");
                    }
                    else if (productDescription.Length > 200)
                    {
                        Console.WriteLine("Product Description can not be more than 200 characters!");
                    }
                    else if (!char.IsUpper(productDescription[0]))
                    {
                        Console.WriteLine("Product Description start with an upper letter!");
                    }
                    else
                    {
                        product1.Description = productDescription;
                        break;
                    }
                    Console.WriteLine("Please enter again! Product Description: ");
                    productDescription = Console.ReadLine();
                }

                /* --------------- Product Price ---------------- */


                Console.Write("Product Price: ");
                string price = Console.ReadLine();
                while (true)
                {
                    decimal productPrice;
                    if (decimal.TryParse(price, NumberStyles.Any, CultureInfo.InvariantCulture, out productPrice))
                    {
                        product1.Price = productPrice;
                        break;
                    }
                    Console.WriteLine("Please enter again! Product Price: ");
                    price = Console.ReadLine();
                }


                /* --------------- Product Count ---------------- */


                Console.Write("Product Count: ");
                string count = Console.ReadLine();
                while (true)
                {
                    int productCount;
                    if (int.TryParse(count, NumberStyles.Any, CultureInfo.InvariantCulture, out productCount))
                    {
                        product1.Count = productCount;
                        break;
                    }
                    else if (!count.All(c => char.IsNumber(c)))
                    {
                        Console.WriteLine("Product Count must contain only numbers!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid count! Plea, enter again!");
                        count = Console.ReadLine();
                    }
                    Console.WriteLine("Please enter again! Product Count: ");
                    count = Console.ReadLine();
                }


                /* --------------- Product Category ---------------- */


                Console.Write("Product Category: ");
                string productCategory = Console.ReadLine();
                while (true)
                {
                    if (string.IsNullOrWhiteSpace(productCategory))
                    {
                        Console.WriteLine("Product Category can not be empty!");
                    }
                    else if (productCategory.Length < 3)
                    {
                        Console.WriteLine("Product Category can not be less than 3 characters");
                    }
                    else if (productCategory.Length > 30)
                    {
                        Console.WriteLine("Product Category can not be more than 30 characters!");
                    }
                    else if (!char.IsUpper(productCategory[0]))
                    {
                        Console.WriteLine("Product Category start with an upper letter!");
                    }
                    else if (!productCategory.All(c => char.IsLetter(c)))
                    {
                        Console.WriteLine("Product Category must contain only letters!");
                    }
                    else
                    {
                        product1.Category = productCategory;
                        break;
                    }
                    Console.WriteLine("Please enter again! Product Category: ");
                    productCategory = Console.ReadLine();
                }


                /* --------------- Product Factory Name ---------------- */


                Console.Write("Product Factory Name: ");
                string factoryName = Console.ReadLine();
                while (true)
                {
                    if (string.IsNullOrWhiteSpace(factoryName))
                    {
                        Console.WriteLine("Factory Name can not be empty!");
                    }
                    else if (factoryName.Length < 3)
                    {
                        Console.WriteLine("Factory Name can not be less than 3 characters");
                    }
                    else if (factoryName.Length > 30)
                    {
                        Console.WriteLine("Factory Name can not be more than 30 characters!");
                    }
                    else if (!char.IsUpper(factoryName[0]))
                    {
                        Console.WriteLine("Factory Name start with an upper letter!");
                    }
                    else if (!factoryName.All(c => char.IsLetter(c)))
                    {
                        Console.WriteLine("Factory Name must contain only letters!");
                    }
                    else
                    {
                        product1.FactoryName = factoryName;
                        break;
                    }
                    Console.WriteLine("Please enter again! Product Factory Name: ");
                    factoryName = Console.ReadLine();
                }


                /* --------------- Product Made Date ---------------- */


                Console.WriteLine("Product Made Date (yyyy-mm-dd): ");
                int yil, oy, kun;
                Console.Write("Product Made Year: ");
                string year = Console.ReadLine();
                while (true)
                {
                    int madeYear;
                    if (int.TryParse(year, NumberStyles.Any, CultureInfo.InvariantCulture, out madeYear))
                    {
                        yil = madeYear;
                        break;
                    }
                    else if (!year.All(c => char.IsNumber(c)))
                    {
                        Console.WriteLine("Product Made Year must contain only numbers!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid year! Plea, enter again!");
                    }
                    Console.WriteLine("Please enter again! Product Made Year: ");
                    year = Console.ReadLine();
                }

                Console.Write("Product Made Month (1 - 12): ");
                string month = Console.ReadLine();
                while (true)
                {
                    int madeMonth;
                    if (int.TryParse(month, NumberStyles.Any, CultureInfo.InvariantCulture, out madeMonth))
                    {
                        oy = madeMonth;
                        break;
                    }
                    else if (!month.All(c => char.IsNumber(c)))
                    {
                        Console.WriteLine("Product Made Month must contain only numbers!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid month! Plea, enter again!");
                    }
                    Console.WriteLine("Please enter again! Product Made Month: ");
                    month = Console.ReadLine();
                }

                Console.Write("Product Made Day (1 - 31): ");
                string day = Console.ReadLine();
                while (true)
                {
                    int madeDay;
                    if (int.TryParse(day, NumberStyles.Any, CultureInfo.InvariantCulture, out madeDay))
                    {
                        kun = madeDay;
                        break;
                    }
                    else if (!day.All(c => char.IsNumber(c)))
                    {
                        Console.WriteLine("Product Made Day must contain only numbers!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Day! Plea, enter again!");
                    }
                    Console.WriteLine("Please enter again! Product Made Day: ");
                    day = Console.ReadLine();
                }
                product1.MadeDate = new DateTime(yil, oy, kun);


                /* --------------- Product Expire Date ---------------- */

                Console.WriteLine("Product Expire Date (yyyy-mm-dd): ");
                int expYil, expOy, expKun;
                Console.Write("Product Expire Year: ");
                string expYear = Console.ReadLine();
                while (true)
                {
                    int expireYear;
                    if (int.TryParse(expYear, NumberStyles.Any, CultureInfo.InvariantCulture, out expireYear))
                    {
                        expYil = expireYear;
                        break;
                    }
                    else if (!expYear.All(c => char.IsNumber(c)))
                    {
                        Console.WriteLine("Product Expire Year must contain only numbers!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid year! Plea, enter again!");
                    }
                    Console.Write("Please enter again! Product Expire Year: ");
                    expYear = Console.ReadLine();
                }

                Console.Write("Product Expire Month (1 - 12): ");
                string expMonth = Console.ReadLine();
                while (true)
                {
                    int expireMonth;
                    if (int.TryParse(expMonth, NumberStyles.Any, CultureInfo.InvariantCulture, out expireMonth))
                    {
                        expOy = expireMonth;
                        break;
                    }
                    else if (!expMonth.All(c => char.IsNumber(c)))
                    {
                        Console.WriteLine("Product Expire Month must contain only numbers!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid month! Plea, enter again!");
                    }
                    Console.Write("Please enter again! Product Expire Month: ");
                    expMonth = Console.ReadLine();
                }

                Console.Write("Product Expire Day (1 - 31): ");
                string expDay = Console.ReadLine();
                while (true)
                {
                    int expireDay;
                    if (int.TryParse(expDay, NumberStyles.Any, CultureInfo.InvariantCulture, out expireDay))
                    {
                        expKun = expireDay;
                        break;
                    }
                    else if (!expDay.All(c => char.IsNumber(c)))
                    {
                        Console.WriteLine("Product Expire Day must contain only numbers!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid Day! Plea, enter again!");
                    }
                    Console.Write("Please enter again! Product Expire Day: ");
                    expDay = Console.ReadLine();
                }
                product1.ExpireDate = new DateTime(expYil, expOy, expKun);

                return "Product is successfully updated!";
            }
            else
            {
                return "Product not found!";
            }

        }



        /* ----------------- Delete Product --------------------  */


        public string DeleteProduct(Guid Id)
        {
            Product product = Products.FirstOrDefault(p => p.Id == Id);
            if (product != null)
            {
                Products.Remove(product);
                return "Product is successfully deleted!";
            }
            else
            {
                return "Product not found!";
            }
        }

        public Product GetProductById(Guid Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByCategory(string category)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProductsByFactory(string factoryName)
        {
            throw new NotImplementedException();
        }

        
    }
}
