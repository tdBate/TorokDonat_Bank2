using System.Runtime.Intrinsics;

namespace Bank2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank b1 = new Bank(2);
            Owner o1 = new Owner();
            o1.Name = "Csapbetét Csabi";

            Owner o2 = new Owner();
            o2.Name = "Gipsz Jakab";

            //példányosítás
            b1.Accounts[0] = b1.NewAccount(o1, 1000);
            b1.Accounts[1] = b1.NewAccount(o2, 1002);

            //deposit és withdraw
            b1.Accounts[0].Deposit(200);
            b1.Accounts[0].Withdraw(100); //valamiért nem működik az override
            Console.WriteLine("1. balance: "+b1.Accounts[0].Balance);

            b1.Accounts[1].Deposit(300);
            b1.Accounts[1].Withdraw(100);
            Console.WriteLine("2. balance: "+b1.Accounts[1].Balance);

            Console.WriteLine("Totalbalance: "+b1.TotalBalance(o1));
            b1.MaximalBalanceAccount(o1);
            Console.WriteLine("TotalCreditLimit: "+b1.TotalCreditLimit());

            //bankcard
            BankCard card1 = new BankCard(o1, 100, "1234");
            Console.WriteLine("\n\nKártya vásárlás előtt:");
            Console.WriteLine(card1.AccountBalance);
            card1.Purchase(50);
            Console.WriteLine("\nKártya vásárlás után:");
            Console.WriteLine(card1.AccountBalance);

            card1.Purchase(1000);
            Console.WriteLine(card1.AccountBalance+" - ezt már nem engedi");

            Console.ReadKey();


        }
    }
}
