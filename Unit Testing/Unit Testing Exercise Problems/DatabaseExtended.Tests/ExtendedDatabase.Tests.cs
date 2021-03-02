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
            var data = new ExtendedDatabase.ExtendedDatabase(new Person(12345, "Milen"));

            Assert.Throws<InvalidOperationException>(() =>
            data.Add(new Person(32313, "Milen")), "There is already user with this username!");
        }

        [Test]
        public void Test_For_Invalid_Operation_Exception_When_ID_Already_Exist()
        {
            var data = new ExtendedDatabase.ExtendedDatabase(new Person(123456, "Galin"));

            Assert.Throws<InvalidOperationException>(() =>
            data.Add(new Person(123456, "Shestaki")), "There is already user with this Id!");
        }

        [Test]
        public void Test_For_Alredy_Removed_Person()
        {
            var data = new ExtendedDatabase.ExtendedDatabase()
        }
    }
}