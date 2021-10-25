using System.Threading;

namespace KataBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Client.deposit(2500);
            Thread.Sleep(1000);
            Client.withdraw(500);
            Thread.Sleep(1000);
            Client.deposit(50);
            Client.printAccountStatement();
        }
    }
}
