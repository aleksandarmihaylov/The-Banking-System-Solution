using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Banking_System.Models
{
    public class BankAccount
    {
        private float money;

        public BankAccount()
        {

        }

        public void AddMoney(float money)
        {
            this.money += money;
        }

        public void RemoveMoney(float money)
        {
            this.money -= money;
        }

        public float GetMoney()
        {
            return money;
        }
    }
}
