using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Investment : IAccountStatement   // IGetBalance is inheritance 
    {
        public Account account { get; set; }

        public void Deposit(double amount)
        {
            account.Deposit(amount);
        }

        public void Withdraw(double amount)
        {
            account.Withdraw(amount);
        }

        public double GetBalance()
        {
            return account.GetBalance();
        }


        public Investment()
        {
            account = new Account();
            account.Id = 1000;
            account.Description = "Primary Investment Account";
            account.Balance = 0.0;
            account.Owner = new Customer(111, "Marge Simpson");
         }

        public string ToPrint()
        {
            string message = account.ToPrint();
            return message + ", Primary Investment Account";
        }
    }
}
