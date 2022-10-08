using System;
using Humanizer;

namespace MySuperBank
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("car".Pluralize());
            //Console.WriteLine("octopus".Pluralize());



            BankAccount account = new BankAccount("Mogboluwaga", 1000);
            account.MakeWithdrawal(500, DateTime.Now, "Rent payment");
            account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
            account.MakeDeposit(2000, DateTime.Now, "October Salary");
            account.MakeWithdrawal(200, DateTime.Now, "Food");
            Console.WriteLine(account.GetAccountHistory());
            //Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");
        }
    }
}
