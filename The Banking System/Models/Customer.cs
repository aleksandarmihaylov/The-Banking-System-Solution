using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banking_System.Models
{
    public class Customer : Person
    {
        private static int autoIncrementId = 1;
        private BankAccount bankAccounts;

        public Customer(string newName) : base(newName)
        {
            bankAccounts = new BankAccount();
            Id = autoIncrementId;
            Name = newName;
            autoIncrementId++;
        }

        public void AddMoney(float money)
        {
            bankAccounts.AddMoney(money);
        }

        public void RemoveMoney(float money)
        {
            bankAccounts.RemoveMoney(money);
        }

        public float GetMoney()
        {
            return bankAccounts.GetMoney();
        }
    }
}
