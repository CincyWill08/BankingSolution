using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking

    // The ToPrints in this application are an example of Polymorphism
{
    class Program
    {
        static int Main(string[] args)
        {
            Account acct1 = new Account();

            acct1.Id = 1;
            acct1.Description = "Primary Account";
            acct1.Balance = 0.0;
            acct1.Owner = new Customer(100, "W Michael Robinson");
            Console.WriteLine(acct1.ToPrint());

            acct1.Deposit(-5.00);
            Console.WriteLine("The balance is " + acct1.GetBalance() + ".");

            acct1.Deposit(5.00);
            Console.WriteLine("The balance is " + acct1.GetBalance() + ".");

            acct1.Withdraw(5000.00);
            Console.WriteLine("The balance is " + acct1.GetBalance() + ".");

            Savings sav2 = new Savings();
            sav2.Id = 2;
            sav2.Description = "Primary Savings Account";
            sav2.Balance = 0.0;
            sav2.Owner = new Customer(101, "Lisa Simpson");
            sav2.IntRate = 0.12;

            sav2.Deposit(1000.00);
            Console.WriteLine(sav2.ToPrint());

            Checking chk1 = new Checking();
            chk1.Id = 3;
            chk1.Description = "Primary Checking Account";
            chk1.Balance = 0.0;
            chk1.Owner = new Customer(102, "Homer Simpson");

            chk1.Deposit(2000.00);
            Console.WriteLine(chk1.ToPrint());

            Checking chka = new Checking();
            chka.Id = 3;
            chka.Description = "Primary Checking Account";
            chka.Balance = 0.0;
            chka.Owner = new Customer(102, "Homer Simpson");

            chka.Deposit(2000.00);
            
            Checking chkb = new Checking();
            chkb.Id = 3;
            chkb.Description = "Secondary Checking Account";
            chkb.Balance = 0.0;
            chkb.Owner = new Customer(102, "Homer Simpson");

            chkb.Deposit(2000.00);
            
            Savings sava = new Savings();
            sava.Id = 2;
            sava.Description = "Primary Savings Account";
            sava.Balance = 0.0;
            sava.Owner = new Customer(102, "Homer Simpson");
            sava.IntRate = 0.12;

            sava.Deposit(1000.00);

            Investment inv1 = new Investment();
            inv1.Deposit(500.00);
            Console.WriteLine(inv1.ToPrint());

            IAccountStatement[] accountsArray = { chka, chkb, sava, inv1 };

            double grandTotal = 0;
            foreach(IAccountStatement acct in accountsArray)
            {
                double acctBalance = acct.GetBalance();
                grandTotal = grandTotal + acctBalance;
                Console.WriteLine(acct.ToPrint());
            }

            Console.WriteLine("Grand Total is " + grandTotal);

            Console.ReadKey();
            return 0;
        }
    }
}
