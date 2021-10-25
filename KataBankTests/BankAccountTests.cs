using Microsoft.VisualStudio.TestTools.UnitTesting;
using KataBank;

namespace KataBankTests
{
    [TestClass]
    public class BankAccountTests
    {
        [TestMethod]
        public void addOperationSuccessTest()
        {
            BankAccount account = new BankAccount();
            Operation expected = new Operation(100, "DEPOSIT");

            account.addOperation(expected);

            Operation actual = account.getOperations()[0];
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void addOperationFailedTest()
        {
            BankAccount account = new BankAccount();
            Operation expected = new Operation(100, "DEPOSIT");

            account.addOperation(new Operation(200, "WITHDRAW"));

            Operation actual = account.getOperations()[0];
            Assert.AreNotEqual(expected, actual);
        }
    }
}
