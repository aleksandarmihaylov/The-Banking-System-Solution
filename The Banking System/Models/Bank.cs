using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banking_System.Models
{
    //creating the Bank class
    public class Bank
    {
        // initialising the Bank's properties with the easier way of encapsulating
        public int Id { get; }
        public string BankName { get; set; }
        private List<Customer> customers;

        //creating the constructor for this class
        public Bank(int Id, string BankName)
        {
            this.customers = new List<Customer>();
            this.Id = this.Id;
            this.BankName = BankName;
        }

        public void AddCustomer (Customer customer)
        {
            customers.Add(customer);
        }

        public Customer FindCustomer(int id)
        {
            Customer foundCustomer = null;
            foreach (Customer myFoundCustomer in customers)
            {
                if(myFoundCustomer.Id == id)
                {
                    foundCustomer = myFoundCustomer;
                }
            }
            return foundCustomer;
        }

        public List<Customer> GetCustomers()
        {
            return customers;
        }

        public void EditCustomer(int id, string newName)
        {
            Customer myCustomerToEdit = FindCustomer(id);
            if (myCustomerToEdit != null)
            {
                myCustomerToEdit.Name = newName;
            }
            else
            {
                Console.WriteLine("Invalid customer id!");
            }
        }

        public void DeleteCustomer(int id)
        {
            Customer myCustomerToDelete = FindCustomer(id);
            if(myCustomerToDelete != null)
            {
                customers.Remove(myCustomerToDelete);
            }
            else
            {
                Console.WriteLine("Invalid customer id!");
            }
        }

        public string TransferMoneyFromCustomers(int givingCustomerId, int recievingCustomerId, float amount)
        {
            Customer givingCustomer = FindCustomer(givingCustomerId);
            Customer recievingCustomer = FindCustomer(recievingCustomerId);
            string result = "";
            if(givingCustomer != null && recievingCustomer != null)
            {
                if (givingCustomer.GetMoney() >= amount)
                {
                    SendMoney(givingCustomer, recievingCustomer, amount);
                    result = "Transfer successful";
                }
                else
                {
                    result = "You have not enough money in your Bank Account";
                }
            }
            else
            {
                result = "Invalid customer ID";
            }
            return result;
        }

        private void SendMoney(Customer givingCustomer, Customer recievingCustomer, float amount)
        {
            givingCustomer.RemoveMoney(amount);
            recievingCustomer.AddMoney(amount);
        }

    }
}
