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
        public void Test_If_Trying_To_Remove_Person_When_Collection_Is_Empty()
        {
            var data = new ExtendedDatabase.ExtendedDatabase();

            Assert.Throws<InvalidOperationException>(() =>
           data.Remove(), "The collection is empty!");
        }

        [Test]
        public void Test_Find_By_Username_When_The_Name_Is_Empry()
        {
            var username = "";
            var data = new ExtendedDatabase.ExtendedDatabase(new Person(1234, ""));

            Assert.Throws<ArgumentNullException>(() =>
            data.FindByUsername(username), "Username parameter is null!");
        }

        [Test]
        public void Test_If_No_User_With_Current_Username()
        {
            var data = new ExtendedDatabase.ExtendedDatabase();
        }
    }
}