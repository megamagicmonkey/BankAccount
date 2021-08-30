using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class BankAccount
    {
        private double balance = 0;


        public void Deposit(double num)
        {
            balance += num;
        }

        public void GetBalance()
        {
            Console.WriteLine($"${balance}");
        }
    }
}
