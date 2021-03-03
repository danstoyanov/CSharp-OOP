using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private readonly int[] array = new int[16];
        private Database.Database data;

        [SetUp]
        public void Setup()
        {
            this.data = new Database.Database();
        }

        [TestCase(new int[] { 1, 2, 3, 4})]
        [TestCase(new int[] { })]
        public void Capacity_Test_Are_Equal_To_Sixteen(int[] array)
        {
            // Arrange
            this.data = new Database.Database(array);

            // Act
            int expectedCount = array.Length;
            int actualCount = this.data.Count;

            // Assert
            Assert.AreEqual(expectedCount, actualCount);
        }

        [Test]
        public void Try_To_Add_Element_At_The_Free_Cell()
        {
            // Arrange
            const int ADD_VALUE = 23;

            this.data = new Database.Database(this.array);

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
            // Arrange
            this.data = new Database.Database();

            // Assert
            Assert.That(() => data.Remove(),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("The collection is empty!"));
        }
    }
}