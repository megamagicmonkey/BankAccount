using System;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount myAcct = new BankAccount();

            Console.WriteLine("Welcome to Minimal Banking banking services! We see you have an account! Would you like to make a deposit?");
            Console.WriteLine("Of course you do! It's our primary and singular service!");
            Console.WriteLine("Please input the amount to deposit:");
            myAcct.Deposit (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine($"After your deposit, which is in no way having security checks placed on the transaction, your account now holds:");
            myAcct.GetBalance();
        }
    }
}
