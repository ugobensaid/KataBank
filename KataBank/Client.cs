namespace KataBank
{
    public static class Client
    {
        public static BankAccount Account = new BankAccount();

        public static void Deposit(int amount)
        {
            Account.AddOperation(new Operation(amount, "DEPOSIT"));
        }

        public static void Withdraw(int amount)
        {
             Account.AddOperation(new Operation(amount, "WITHDRAW"));
        }
    }
}
