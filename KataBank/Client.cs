using System;
using System.Collections.Generic;

namespace KataBank
{
    class Client
    {
        private static BankAccount account = new BankAccount();

        public static void deposit(int amount)
        {
            account.addOperation(new Operation(amount, "DEPOSIT"));
        }

        public static void withdraw(int amount)
        {
             account.addOperation(new Operation(amount, "WITHDRAW"));
        }

        public static void printAccountStatement()
        {
            List<Operation> operations = account.getOperations();
            List<int> balances = account.getAccountBalance();
            int balance = 0;

            Console.WriteLine(" Operation | Date and time       | Amount    | Balance    \n" +
                "-------------------------------------------------------");
            for (int i = 0; i < operations.Count; i++)
            {
                balance += balances[i];
                Console.WriteLine(String.Format("{0} {1}", operations[i].getOperationInfos(), balance));
            }
        }
    }
}
