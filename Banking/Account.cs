using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account : IAccountStatement
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double Balance { get; set; }
        public Customer Owner { get; set; }


        //The Methods

        public virtual string ToPrint()
        {
            return "Acct Name = " + Owner.FullName + ", Id=" + Id.ToString() + ", " + "Desc = " + Description + ", " + "Balance = " + Balance.ToString();
        
        }



        public void Deposit(double amount)
        {
            if (!IsAmountNegative(amount))
            {
                Balance = Balance + amount;        //= is an assignment statement
            }
            
        }

        public void Withdraw(double amount)
        {             
            if (!IsAmountNegative(amount))
            {
                Balance = Balance - amount;
            }
           
        }

        public double GetBalance()
        {
            return Balance;
        }

        private bool IsAmountNegative(double passedAmount)
        {
            if (passedAmount < 0)
            {
                Console.WriteLine("Amount cannot be negative.");
                return true;
            }
            return false;
        }
           
    }
}
