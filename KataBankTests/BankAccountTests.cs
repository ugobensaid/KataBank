using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataBank;
using Moq;

namespace KataBankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void verifyOperationInListTest()
        {
            Mock<BankAccount> bankAccountMock = new Mock<BankAccount>();
            Client client = new Client(bankAccountMock.Object);

            client.Deposit(200);
            client.Withdraw(100);
            client.Deposit(50);

            int numberOfOperations = client.Account.Operations.Count;
            Assert.AreEqual(3, numberOfOperations);
        }

        [TestMethod]
        public void addOperationAmountSuccessTest()
        {
            Mock<BankAccount> bankAccountMock = new Mock<BankAccount>();
            Client client = new Client(bankAccountMock.Object);

            client.Deposit(100);

            int operationAmount = client.Account.Operations[0].Amount;
            Assert.AreEqual(100, operationAmount);
        }

        [TestMethod]
        public void addOperationTypeSuccessTest()
        {
            Mock<BankAccount> bankAccountMock = new Mock<BankAccount>();
            Client client = new Client(bankAccountMock.Object);

            client.Deposit(100);

            string operationType = client.Account.Operations[0].OperationType;
            Assert.AreEqual(operationType, "DEPOSIT");
        }
    }
}
