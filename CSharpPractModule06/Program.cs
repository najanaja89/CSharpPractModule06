using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat;

namespace CSharpPractModule06
{
    class Program
    {
        static void Main(string[] args)
        {

            Client client = new Client("Ruslan Tyo", "1234", "123456");
            Bank bank = new Bank(100);
            Account account = new Account(client);
            int count = 3;
            string pin = "";

            while (count <= 3)
            {
                Console.WriteLine("Enter pin");
                pin = Console.ReadLine();
                if (pin == client.Pin)
                {
                    pin = "correct";
                    break;
                }
                else Console.WriteLine("Pin incorrect");
                count--;
                if (count == 0)
                {
                    Console.WriteLine("You entered incorrect pin 3 times. Card is blocked.");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }

            while (true)
            {
                Console.WriteLine("Press 1 to view balance from account");
                Console.WriteLine("Press 2 to refill account");
                Console.WriteLine("Press 3 to take off cash from account");
                Console.WriteLine("Press any key to exit");
                string menu = Console.ReadLine();
                if (menu == "1")
                {
                    Console.WriteLine("Your balance is " + bank.Balance);
                    Console.WriteLine("Press 1 to return in menu");
                    Console.WriteLine("Press any key to exit");
                    menu = Console.ReadLine();
                    if (menu == "1") continue;
                    else Environment.Exit(0);
                }

                else if (menu == "2")
                {
                    Console.WriteLine("Enter sum to fill");
                    string sum = Console.ReadLine();
                    bool result = double.TryParse(sum, out double sumDouble);
                    if (result == false)
                    {
                        Console.WriteLine("sum must be a number!");
                        continue;
                    }
                    else if (sumDouble <= 0)
                    {
                        Console.WriteLine("sum must be more than 0!");
                        continue;
                    }
                    bank.Balance += sumDouble;

                    Console.WriteLine("Press 1 to return in menu");
                    Console.WriteLine("Press any key to exit");
                    menu = Console.ReadLine();
                    if (menu == "1") continue;
                    else Environment.Exit(0);
                }
                else if (menu == "3")
                {
                    Console.WriteLine("Enter sum to take off");
                    string sum = Console.ReadLine();
                    bool result = double.TryParse(sum, out double sumDouble);
                    if (result == false)
                    {
                        Console.WriteLine("sum must be a number!");
                        continue;
                    }
                    if (sumDouble > bank.Balance || sumDouble <= 0)
                    {
                        Console.WriteLine("Entered sum more than your balance!");
                        continue;
                    }
                    Console.WriteLine("Sum was taked off from your balance!");
                    bank.Balance -= sumDouble;
                    Console.WriteLine("Your balance is " + bank.Balance);

                    Console.WriteLine("Press 1 to return in menu");
                    Console.WriteLine("Press any key to exit");
                    menu = Console.ReadLine();
                    if (menu == "1") continue;
                    else Environment.Exit(0);
                }

            }
        }
    }
}
