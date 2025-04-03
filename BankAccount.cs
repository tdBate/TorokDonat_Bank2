using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank2
{
    internal abstract class BankAccount : BankingService
    {
        double balance;

        public double Balance { get => balance; protected set => balance = value; }

        public BankAccount(Owner owner) : base(owner)
        {
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public abstract bool Withdraw(double amount);

        public BankCard NewCard(string cardNumber)
        {
            return new BankCard(Owner, Balance, cardNumber);
        }
    }
}
