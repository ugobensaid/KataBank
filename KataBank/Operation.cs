using System;

namespace KataBank
{
    class Operation
    {
        private int amount;
        private string dateTime;
        private string operationType;

        public Operation(int amount, string operationType)
        {
            this.amount = amount;
            this.dateTime = getCurrentDateTime();
            this.operationType = operationType;
        }

        public string getOperationInfos()
        {
            return String.Format(" {0}{1} | {2} | {3}{4} |", operationType, printSpaces(operationType), 
                dateTime, amount, printSpaces(amount));
        }

        public int getAmount()
        {
            return amount;
        }

        public string getOperationType()
        {
            return operationType;
        }

        private static string getCurrentDateTime()
        {
            return DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
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
