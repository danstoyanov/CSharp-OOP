using NUnit.Framework;

using P03_MyTestDemos.App;

namespace P03_TestDemos.UnitTest
{
    [TestFixture]
    public class BankAccountTests
    {
        [Test]
        public void CreatingBankAccountShouldSetInitialAmount()
        {
            //Arrange
            const int amount = 2000;

            // Act
            var bankAccount = new BankAccount(amount);

            //Assert 
            Assert.That(bankAccount.Ammount, Is.EqualTo(amount));
        }
    }
}
