using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private int[] testArray = new int[16];

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Capacity_Test_Are_Equal_To_Sixteen()
        {
            // Arrange
            var data = new Database(this.testArray);

            // Act
            var arrSize = this.testArray.Length;

            // Assert
            Assert.AreEqual(data.Count, arrSize);
        }

        [Test]
        public void Try_To_Add_Element_At_The_Free_Cell()
        {
            // Arrange
            const int ADD_VALUE = 23;

            var data = new Database(this.testArray);

            // Assert
            Assert.That(() => data.Add(ADD_VALUE),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("Array's capacity must be exactly 16 integers!"));
        }

        [Test]
        public void Remove_Element_From_Empty_Array_And_Throw_Exception()
        {

        }
    }
}