using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banking_System.Models
{
    public class CustomerService
    {
        public static void CreateCustomer(Bank bank)
        {
            Console.WriteLine("--- Create new Customer ---");
            Console.Write("Please enter the name: ");
            string name = Console.ReadLine();
            //create customer
            Customer currentCustomer = new Customer(name);
            bank.AddCustomer(currentCustomer);
        }

        public static void EditCustomer(Bank bank)
        {
            Console.WriteLine("--- Edit your Customer ---");
            Console.Write("Please enter the id of the customer you want to edit: ");
            string id = Console.ReadLine();
      
            Console.Write("Please enter the new name of the customer you want to edit: ");
            string newName = Console.ReadLine();

            bank.EditCustomer(int.Parse(id), newName);
        }

        public static void DeleteCustomer(Bank bank)
        {
            Console.WriteLine("--- Delete your Customer ---");
            Console.Write("Please enter the id of the customer you want to delete: ");
            string id = Console.ReadLine();
            bank.DeleteCustomer(int.Parse(id));
        }

        public static void ShowAllCustomers(Bank bank)
        {
            Console.Clear();
            Console.WriteLine();
            foreach (Customer myCustomer in bank.GetCustomers())
            {
                Console.WriteLine("ID: " + myCustomer.Id + " " + "Name: " + myCustomer.Name + " " + "Money: " + myCustomer.GetMoney());
            }
            Console.WriteLine("---------");
            CustomerOperations(bank);
        }

        private static void CustomerOperations(Bank bank)
        {
            Console.WriteLine("1: Deposit, 2: Transfer, 3: Return to main many");

            string command = Console.ReadLine();
            switch (command)
            {
                case "1":
                    //deposit
                    //first find the customer, then deposit the ammount to his bank accounts money
                    Console.Write("Enter the id of the customer: ");
                    string customerId = Console.ReadLine();
                    int theCustomerId = int.Parse(customerId);
                    Customer myFoundCustomer = bank.FindCustomer(theCustomerId);
                    if (myFoundCustomer != null)
                    {
                        Console.WriteLine("Enter the amount to deposit: ");
                        string amount = Console.ReadLine();
                        myFoundCustomer.AddMoney(float.Parse(amount));
                    }
                    else
                    {
                        Console.WriteLine("Invalid Customer ID");
                    }
                    break;
                case "2":
                    //transfer
                    Console.Write("Enter the id of the customer you want to send money from: ");
                    string firstCustomerId = Console.ReadLine();
                    Console.Write("Enter the id of the customer who recieves the money: ");
                    string secondCustomerId = Console.ReadLine();
                    Console.Write("Enter the amount of money you want to send: ");
                    string transferAmount = Console.ReadLine();
                    string result = bank.TransferMoneyFromCustomers(int.Parse(firstCustomerId), int.Parse(secondCustomerId), float.Parse(transferAmount));
                    Console.WriteLine(result);
                    break;
                case "3":
                    //return to main many
                    break;
                default:
                    Console.WriteLine("Enter a valid number");
                    CustomerOperations(bank);
                    break;
            }
        }
    }
}
