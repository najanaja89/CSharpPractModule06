using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Account
    {
        public string AccountNumber { set; get; }
        public Account(Client c1)
        {
            AccountNumber = c1.AccountNumber;
        }
    }
}
