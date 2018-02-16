using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Checking : Account
    {
        public int LastCheckNumber { get; set; }

        public override string ToPrint()
        {
            string message = base.ToPrint();
            return message + ", LastCheck = " + LastCheckNumber.ToString();
        }
    }
}
   
