using System;
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
            var testPerson = new Person(31313131, "Gesha");
            var data = new ExtendedDatabase(new Person(31313131, "Gesha"));

            //Act

            //Assert
            Assert.That(() => data.Add(TEST_PERSON),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("There is already user with this username!"));
        }
    }
}