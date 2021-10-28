using System.Collections.Generic;

namespace KataBank
{
    public class BankAccount
    {
        public List<Operation> Operations { get; }

        public BankAccount()
        {
            Operations = new List<Operation>();
        }

        public void AddOperation(Operation operation)
        {
            Operations.Add(operation);
        }

        public List<int> GetAccountBalance()
        {
            List<int> balances = new List<int>();

            for (int i = 0; i < Operations.Count; i++)
            {
                if (Operations[i].OperationType == "WITHDRAW")
                    balances.Add(-1 * Operations[i].Amount);
                else
                    balances.Add(Operations[i].Amount);
            }
            return balances;
        }
    }
}
