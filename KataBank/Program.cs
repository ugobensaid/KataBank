using System.Threading;

namespace KataBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.Deposit(2500);
            Thread.Sleep(1000);
            Client.Withdraw(500);
            Thread.Sleep(1000);
            Client.Deposit(50);
            Printer.PrintAccountStatement();
        }
    }
}
