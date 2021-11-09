using System.Threading;

namespace KataBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client(new BankAccount());

            client.Deposit(2500);
            Thread.Sleep(1000);
            client.Withdraw(500);
            Thread.Sleep(1000);
            client.Deposit(50);
            Printer.PrintAccountStatement(client);
        }
    }
}
