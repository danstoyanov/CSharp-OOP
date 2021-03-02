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
        public void Test_For_Invalid_Operation_Exeptin_When_Username_Already_Exist()
        {
            var data = new ExtendedDatabase.ExtendedDatabase(new Person(123133, "Gicho"));

            //Arrange


            //Act

            //Assert
        }
    }
}