using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzumMarket.Models.Roles;
using UzumMarket.Services.IServices;

namespace UzumMarket.Services
{
    public class CustomerService : ICustomerService
    {
        public static List<Customer> Customers { get; set; } = new List<Customer>();

        public string Deposit()
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public string Login()
        {
            throw new NotImplementedException();
        }

        public string ManageOrders()
        {
            throw new NotImplementedException();
        }

        public string Register(Customer customer)
        {
            Console.Clear();
            Console.WriteLine("\nRegistering a new customer...\n");

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(firstName))
                {
                    Console.WriteLine("First Name can not be empty. Please try again: ");
                }
                else if (firstName.Length is < 3 or > 20)
                {
                    Console.WriteLine("First Name must be between 3 and 20 characters. Please try agai: ");
                }
                else if (!char.IsUpper(firstName[0]))
                {
                    Console.WriteLine("First Name must start with an uppercase letter. Please try again: ");
                }
                else if (firstName.Any(char.IsDigit))
                {
                    Console.WriteLine("First Name can not contain numbers. Please try again: ");
                }
                else if (firstName.Any(char.IsSymbol))
                {
                    Console.WriteLine("First Name can not contain symbols. Please try again: ");
                }
                else
                {
                    customer.FirstName = firstName;
                    break;
                }
                firstName = Console.ReadLine();
            }

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(lastName))
                {
                    Console.WriteLine("Last Name cannot be empty. Please try again: ");
                }
                else if (lastName.Length is < 3 or > 20)
                {
                    Console.WriteLine("Last Name must be between 3 and 20 characters. Please try again: ");
                }
                else if (!char.IsUpper(lastName[0]))
                {
                    Console.WriteLine("Last Name must start with an uppercase letter. Please try again: ");
                }
                else if (lastName.Any(char.IsDigit))
                {
                    Console.WriteLine("Last Name cannot contain numbers. Please try again: ");
                }
                else if (lastName.Any(char.IsSymbol))
                {
                    Console.WriteLine("Last Name cannot contain symbols. Please try again: ");
                }
                else
                {
                    customer.LastName = lastName;
                    break;
                }
                lastName = Console.ReadLine();
            }

            Console.Write("Age (20 - 30): ");
            string age = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(age, NumberStyles.Any, CultureInfo.InvariantCulture, out int ageTrue))
                {
                    if (ageTrue > 20 || ageTrue < 30)
                    {
                        customer.Age = ageTrue;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Age must be between 20 and 30. Please try again: ");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid age. Please enter a valid number: ");
                }
                age = Console.ReadLine();
            }

            Console.WriteLine("Date of Birth (yyyy-mm-dd): ");
            int year, month, day;

            Console.Write("Enter Year: ");
            string yearInput = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(yearInput, out year))
                {
                    if (year > 1995)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Year must be between 1995 and the current year. Please try again: ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid year. Please enter a valid number: ");
                }
                yearInput = Console.ReadLine();
            }

            Console.Write("Enter Month (1 - 12): ");
            string monthInput = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(monthInput, out month))
                {
                    if (month > 0 && month <= 12)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Month must be between 1 and 12. Please try again: ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid month. Please enter a valid number: ");
                }
                monthInput = Console.ReadLine();
            }

            Console.Write("Enter Day: ");
            string dayInput = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(dayInput, out day))
                {
                    if (day > 0 && day <= 31)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Day must be between 1 and 31. Please try again: ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid day. Please enter a valid number: ");
                }
                dayInput = Console.ReadLine();
            }
            customer.DateOfBirth = new DateTime(year, month, day);


            Console.WriteLine("Gender (Male or Female): ");
            string gender = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(gender))
                {
                    Console.WriteLine("Gender can not be an empty! Please, try again: ");
                }
                else if (!gender.All(g => char.IsLetter(g)))
                {
                    Console.WriteLine("Gender must contain only letters! Please, try again!");
                }
                else
                {
                    customer.Gender = gender;
                    break;
                }
                gender = Console.ReadLine();
            }

            Console.Write("Address: ");
            string address = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(address))
                {
                    Console.WriteLine("Address cannot be empty. Please try again: ");
                }
                else if (address.Length is < 5 or > 80)
                {
                    Console.WriteLine("Address must be between 5 and 80 characters. Please try again: ");
                }
                else
                {
                    customer.Address = address;
                    break;
                }
                address = Console.ReadLine();
            }

            /* ----------------- Phone Number ------------------ */

            Console.Write("Phone Number (Start With '+998'):  ");
            string phoneNumber = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(phoneNumber))
                {
                    Console.WriteLine("Phone number cannot be empty. Please try again: ");
                }
                else if (phoneNumber.Length != 13 || !phoneNumber.StartsWith("+998"))
                {
                    Console.WriteLine("Phone number must be in the format +998XXXXXXXXX. Please try again: ");
                }
                else
                {
                    customer.PhoneNumber = phoneNumber;
                    break;
                }
                phoneNumber = Console.ReadLine();
            }

            /* ----------------- Email ------------------ */

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
                    customer.Email = email;
                    break;
                }
                email = Console.ReadLine();
            }

            /* ----------------- Password ------------------ */

            Console.Write("Password: ");
            string password = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrWhiteSpace(password))
                {
                    Console.WriteLine("Password cannot be empty. Please try again: ");
                }
                else if (password.Length < 8)
                {
                    Console.WriteLine("Password must be at least 8 characters long. Please try again: ");
                }
                else if (!password.Any(char.IsDigit))
                {
                    Console.WriteLine("Password must contain at least one digit. Please try again: ");
                }
                else if (!password.Any(char.IsUpper))
                {
                    Console.WriteLine("Password must contain at least one uppercase letter. Please try again: ");
                }
                else
                {
                    customer.Password = password;
                    break;
                }
                password = Console.ReadLine();
            }


            /* ----------------- Deposit ------------------ */

            Console.Write("Balance: ");
            string balance = Console.ReadLine();
            while (true)
            {
                if (decimal.TryParse(balance, NumberStyles.Any, CultureInfo.InvariantCulture, out decimal money))
                {
                    if (money > 0)
                    {
                        customer.Balance = money;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Balance must be greater than 0. Please try again: ");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid balance. Please enter a valid number: ");
                }
                balance = Console.ReadLine();
            }

            Customers.Add(customer);

            Console.Clear();

            return "Customer registered successfully!";
        }


    }
}
