using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account
{
    class Program
    {
        private static void Main(string[] args)
        {
            var bartosAccount = new Account("Barto's account", 100.00);
            var bartosSwissAccount = new Account("Barto's account in Switzerland", 1000000.00);

            Console.WriteLine("Initial state");
            bartosAccount.PrintBalance();
            bartosSwissAccount.PrintBalance();            
            bartosAccount.withdrawal(20);
            bartosSwissAccount.deposit(200);     
            
            Console.WriteLine("Final state");
            bartosAccount.PrintBalance();
            bartosSwissAccount.PrintBalance();

            // TASK 1: Your first account
            var marijasAccount = new Account("Marija's account", 100.00);  
            marijasAccount.deposit(20.00);
            marijasAccount.PrintBalance();

            // TASK 2: Your first money transfer
            var mattsAcount = new Account("Matt's account", 1000.00);  
            var myAccount = new Account("My account", 0.00);
            mattsAcount.withdrawal(100.00);
            myAccount.deposit(100.00);
            mattsAcount.PrintBalance();
            myAccount.PrintBalance();

            // TASK 3: Money transfers
           
            var aAccount = new Account("A", 100.00);
            var bAccount = new Account("B", 0.00);
            var cAccount = new Account("C", 0.00);
            Account.Transfer(aAccount, bAccount, 50.00); // Transfers 50.0 from account A to account B
            Account.Transfer(bAccount, cAccount, 25.00); // Transfers 25.0 from account B to account C

            aAccount.PrintBalance();
            bAccount.PrintBalance();
            cAccount.PrintBalance();



        }
    }
}
