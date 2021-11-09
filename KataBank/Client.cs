namespace KataBank
{
    public class Client
    {
        public BankAccount Account { get; }

        public Client(BankAccount account)
        {
            Account = account;
        }

        virtual public void Deposit(int amount)
        {
            Account.AddOperation(new Operation(amount, "DEPOSIT"));
        }

        virtual public void Withdraw(int amount)
        {
             Account.AddOperation(new Operation(amount, "WITHDRAW"));
        }
    }
}
