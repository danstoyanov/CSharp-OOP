using NUnit.Framework;

using P03_MyTestDemos.App;

namespace P03_TestDemos.UnitTest
{
    [TestFixture]
    public class BankAccountTests
    {
        public void CreatingBankAccountShouldSetInitialAmount()
        {
            var bankAccount = new BankAccount(2000);

            Assert.AreEqual(2000, bankAccount.Ammount);
        }
    }
}