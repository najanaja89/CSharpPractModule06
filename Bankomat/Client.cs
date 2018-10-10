using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    public class Client
    {
        public string FullName { set; get; }
        public string AccountNumber { set; get; }
        public string Pin { set; get; }

        public Client(string fullName, string pin, string accountNumber)
        {
            FullName = fullName;
            AccountNumber = accountNumber;
            Pin = pin;
        }

    }
}
