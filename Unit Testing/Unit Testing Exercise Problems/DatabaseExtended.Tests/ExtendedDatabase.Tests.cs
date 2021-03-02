using ExtendedDatabase;
using NUnit.Framework;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void User_With_Same_Username_Exception()
        {
            //Arrange
            long firstID = 54932233;
            string firstName = "Mincho";

            long secondID = 323132158;
            string secondName = "Ivan";

            var firstPerson = new Person(firstID, firstName);
            var secondPerson = new Person(secondID, secondName);

            var data = new ExtendedDatabase.ExtendedDatabase(firstPerson, secondPerson);

            //Act

            //Assert
        }
    }
}