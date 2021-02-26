using NUnit.Framework;

using P03_MyTestDemos.App;

namespace P03_TestDemos.UnitTest
{
    [TestFixture]
    public class BankAccount_Tests
    {
        [Test]
        public void Creating_Bank_Account_Should_Set_Initial_Amount()
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
