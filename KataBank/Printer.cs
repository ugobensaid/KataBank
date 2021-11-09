using System;
using System.Collections.Generic;

namespace KataBank
{
    public static class Printer
    {
        public static void PrintAccountStatement(Client client)
        {
            List<Operation> operations = client.Account.Operations;
            List<int> balances = client.Account.GetAccountBalance();
            int balance = 0;

            Console.WriteLine(" Operation  | Date and time       | Amount     | Balance    \n" +
                "----------------------------------------------------------");
            for (int i = 0; i < operations.Count; i++)
            {
                balance += balances[i];
                Console.WriteLine(String.Format(" {0} {1} | {2} | {3} {4} | {5}", operations[i].OperationType, 
                    printSpaces(operations[i].OperationType), operations[i].OperationDate.ToString("dd/MM/yyyy HH:mm:ss"),
                    operations[i].Amount, printSpaces(operations[i].Amount), balance));
            }
        }

        private static string printSpaces(object elem)
        {
            int elemLength = elem.ToString().Length;
            string spaces = "";

            for (int i = 0; i <= 8 - elemLength; i++)
            {
                spaces += " ";
            }

            return spaces;
        }
    }
}
