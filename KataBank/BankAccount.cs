using System;
using System.Collections.Generic;

namespace KataBank
{
    class BankAccount
    {
        private List<Operation> operations = new List<Operation>();

        public BankAccount() {}

        public void addOperation(Operation operation)
        {
            operations.Add(operation);
        }

        public List<Operation> getOperations()
        {
            return operations;
        }

        public List<int> getAccountBalance()
        {
            List<int> balances = new List<int>();

            for (int i = 0; i < operations.Count; i++)
            {
                if (operations[i].getOperationType() == "WITHDRAW")
                    balances.Add(-1 * operations[i].getAmount());
                else
                    balances.Add(operations[i].getAmount());
            }
            return balances;
        }
    }
}
