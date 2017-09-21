using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banking_System.Models
{
    public class Engine
    {
        public void Run()
        {
            Bank bank = new Bank(1, "Bank name");
            while (true)
            {
                ShowMainMenu();
                string command = Console.ReadLine();
                switch (command)
                {
                    case "1":
                        CustomerService.CreateCustomer(bank);
                        break;
                    case "2":
                        //showing the customers method
                        CustomerService.ShowAllCustomers(bank);
                        break;
                    case "3":
                        //showing the edit customers method
                        CustomerService.EditCustomer(bank);
                        break;
                    case "4":
                        //showing the delete customers method
                        CustomerService.DeleteCustomer(bank);
                        break;
                    default:
                        Console.WriteLine("Enter a valid number");
                        break;
                }
            }
        }

        private void ShowMainMenu()
        {
            Console.WriteLine("Welcome to the bank");
            Console.WriteLine("-----------------");
            Console.WriteLine("1: Create a customer");
            Console.WriteLine("2: Show Customers");
            Console.WriteLine("3: Edit Customers");
            Console.WriteLine("4: Delete Customers");
            Console.WriteLine("----------");
        }
    }
}
