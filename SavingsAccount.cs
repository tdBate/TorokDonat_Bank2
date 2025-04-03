using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    internal class SavingsAccount : BankAccount
    {
        static double baseInterest = 0.1;

        public double Interest { get; set; }

        public SavingsAccount(Owner owner) : base(owner)
        {
            Interest = baseInterest;
        }

        public override bool Withdraw(double amount)
        {
            if (Balance - amount >= 0)
            {
                
                Balance -= amount;
                return true;
            }
            return false;
        }

        public void AddInterest()
        {
            Balance += Balance * (Interest / 100);
        }
    }
}
