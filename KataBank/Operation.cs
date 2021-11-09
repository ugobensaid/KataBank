using System;

namespace KataBank
{
    public class Operation
    {
        public DateTime OperationDate { get; }

        public int Amount { get; }
        public string OperationType { get; }

        public Operation(int amount, string operationType)
        {
            Amount = amount;
            OperationDate = DateTime.Now;
            OperationType = operationType;
        }
    }
}
