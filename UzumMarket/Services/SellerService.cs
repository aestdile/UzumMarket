using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzumMarket.Models.Roles;
using UzumMarket.Services.IServices;

namespace UzumMarket.Services
{
    public class SellerService : ISellerService
    {
        
        

        public string ManageProducts()
        {
            throw new NotImplementedException();
        }

        public static List<Seller> Sellers { get; set; } = new List<Seller>();

        public string Register(Seller seller)
        {

            /* --------------- Seller First Name ---------------- */


            Console.Clear();
            Console.WriteLine("\nWelcome to the Seller Registration System!\n");

            Console.Write("Seller First Name: ");
            string sellerFirstName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(sellerFirstName))
                {
                    Console.WriteLine("Seller First Name can not be empty!");
                }
                else if (sellerFirstName.Length > 20)
                {
                    Console.WriteLine("Seller First Name can not be more than 20 characters!");
                }
                else if (sellerFirstName.Length < 3)
                {
                    Console.WriteLine("Seller First Name can not be less than 3 characters!");
                }
                else if (!char.IsUpper(sellerFirstName[0]))
                {
                    Console.WriteLine("Seller First Name start with an uppercase letter!");
                }
                else if (!sellerFirstName.All(c => char.IsLetter(c)))
                {
                    Console.WriteLine("Seller First Name must countain only letters!");
                }
                else
                {
                    seller.FirstName = sellerFirstName;
                    break;
                }
                Console.Write("Please, enter again! Seller First Name: ");
                sellerFirstName = Console.ReadLine();
            }

            /* --------------- Seller Last Name ---------------- */

            Console.Write("Seller Last Name: ");
            string sellerLastName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(sellerLastName))
                {
                    Console.WriteLine("Seller Last Name can not be empty!");
                }
                else if (sellerLastName.Length > 20)
                {
                    Console.WriteLine("Seller Last Name can not be more than 20 characters!");
                }
                else if (sellerLastName.Length < 3)
                {
                    Console.WriteLine("Seller Last Name can not be less than 3 characters!");
                }
                else if (!char.IsUpper(sellerLastName[0]))
                {
                    Console.WriteLine("Seller Last Name start with an uppercase letter!");
                }
                else if (!sellerLastName.All(c => char.IsLetter(c)))
                {
                    Console.WriteLine("Seller Last Name must countain only letters!");
                }
                else
                {
                    seller.LastName = sellerLastName;
                    break;
                }
                Console.Write("Please, enter again! Seller Last Name: ");
                sellerLastName = Console.ReadLine();
            }



            /* --------------- Seller Email ---------------- */

            Console.Write("Email: ");
            string email = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.WriteLine("Email cannot be empty. Please try again: ");
                }
                else if (!email.Contains("@") || !email.Contains("."))
                {
                    Console.WriteLine("Email must contain '@' and '.' characters. Please try again: ");
                }
                else
                {
                    seller.Email = email;
                    break;
                }
                email = Console.ReadLine();
            }



            /* --------------- Seller Password ---------------- */

            Console.Write("Seller Password: ");
            string sellerPassword = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(sellerPassword))
                {
                    Console.WriteLine("Seller Password can not be empty!");
                }
                else if (sellerPassword.Length < 8)
                {
                    Console.WriteLine("Seller Password can not be less 8 characters!");
                }
                else if (!sellerPassword.Any(char.IsUpper))
                {
                    Console.WriteLine("Seller Password must contain at least one uppercase letter!");
                }
                else if (!sellerPassword.Any(char.IsLower))
                {
                    Console.WriteLine("Seller Password must contain at least one lowercase letter!");
                }
                else if (!sellerPassword.Any(char.IsDigit))
                {
                    Console.WriteLine("Seller Password must contain at leat one digit!");
                }
                else if (!sellerPassword.Any(ch => "!@#$%^&*()-_=+[{]};:'\",<.>/?".Contains(ch)))
                {
                    Console.WriteLine("Seller Password must contain at least one special character!");
                }
                else if (sellerPassword.Contains(" "))
                {
                    Console.WriteLine("Seller Password can not contain space!");
                }
                else
                {
                    seller.Password = sellerPassword;
                    break;
                }
                Console.Write("Please, enter again! Seller Password: ");
                sellerPassword = Console.ReadLine();
            }


            /* --------------- Seller Position ---------------- */

            Console.Write("Seller Position: ");
            string position = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(position))
                {
                    return "Position cannot be empty";
                }
                else if (position.Length < 3 || position.Length > 20)
                {
                    return "Position must be between 3 and 20 characters";
                }
                else if (!char.IsUpper(position[0]))
                {
                    return "Position must start with an uppercase letter";
                }
                else if (position.Any(char.IsDigit))
                {
                    return "Position cannot contain numbers";
                }
                else if (position.Any(char.IsSymbol))
                {
                    return "Position cannot contain symbols";
                }
                else
                {
                    break;
                }
                Console.Write("Please, enter again! Seller Position: ");
                position = Console.ReadLine();
            }
            seller.Position = position;

            Sellers.Add(seller);
            return "\nSeller is successfully registered!\n";
        }



        /* --------------- Login -------------- */


        public string Login()
        {
            /* --------------- Email ---------------- */

            Console.WriteLine("\nWelcome to the Seller Login System!\n");

            Console.Write("Email: ");
            string email = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(email))
                {
                    Console.WriteLine("Email cannot be empty. Please try again: ");
                }
                else if (!email.Contains("@") || !email.Contains("."))
                {
                    Console.WriteLine("Email must contain '@' and '.' characters. Please try again: ");
                }
                else
                {
                    break;
                }
                email = Console.ReadLine();
            }


            /* --------------- Password ---------------- */

            Console.Write("Password: ");
            string password = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.WriteLine("Password can not be empty!");
                }
                else if (password.Length < 8)
                {
                    Console.WriteLine("Password can not be less 8 characters!");
                }
                else if (!password.Any(char.IsUpper))
                {
                    Console.WriteLine("Password must contain at least one uppercase letter!");
                }
                else if (!password.Any(char.IsLower))
                {
                    Console.WriteLine("Password must contain at least one lowercase letter!");
                }
                else if (!password.Any(char.IsDigit))
                {
                    Console.WriteLine("Password must contain at leat one digit!");
                }
                else if (!password.Any(ch => "!@#$%^&*()-_=+[{]};:'\",<.>/?".Contains(ch)))
                {
                    Console.WriteLine("Password must contain at least one special character!");
                }
                else if (password.Contains(" "))
                {
                    Console.WriteLine("Password can not contain space!");
                }
                else
                {
                    break;
                }
                Console.Write("Please, enter again! Password: ");
                password = Console.ReadLine();
            }

            var seller = Sellers.FirstOrDefault(s => s.Email == email && s.Password == password);
            if (seller != null)
            {
                return "Login is successfull!";
            }
            else
            {
                return "Invalid UserName or Password!";
            }
        }


        /* --------------- GetAllSellers ---------------- */
        public List<Seller> GetAllSellers()
        {
            return Sellers;
        }




    }
}
