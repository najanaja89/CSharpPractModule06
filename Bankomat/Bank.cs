using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Bank
    {
        public double Balance { set; get; }
        public Bank()
        {
            Balance = 0;
        }

        public Bank(double balance)
        {
            Balance = balance;
        }
    }
}
