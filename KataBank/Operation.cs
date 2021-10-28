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

        /*public string GetOperationInfos()
        {
            return String.Format(" {0}{1} | {2} | {3}{4} |", OperationType, Printer.PrintSpaces(OperationType),
                OperationDate.ToString("dd:MM:yyy HH:mm:ss"), Amount, Printer.PrintSpaces(Amount));
        }*/
    }
}
