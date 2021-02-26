using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Dummy_Tests
    {
        [Test]
        public void DummyHealthLosesWhenIsAttacked()
        {
            // Arrange
            var dummy = new Dummy(100, 500);
            const int attackPoints = 99;

            // Act
            dummy.TakeAttack(attackPoints);

            // Assert
            Assert.That(dummy.Health, Is.EqualTo(1));
        }

        [Test]
        public void DummyThrowsExceptionIfHeDead()
        {
            // Arrange
            var dummy = new Dummy(0, 500);
            const int attackPoints = 99;

            // Assert
            Assert.That(() => dummy.TakeAttack(attackPoints),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("Dummy is dead."));
        }

        [Test]
        public void DummyShouldGiveXPIfDead()
        {
            // Arrange
            var dummy = new Dummy(0, 100);

            // Act 
            var experience = dummy.GiveExperience();

            // Assert
            Assert.That(experience, Is.EqualTo(100));
        }

        [Test]
        public void DummyShouldNotGiveXPIfAlive()
        {
            // Arrange
            var dummy = new Dummy(5, 100);

            // Assert
            Assert.That(() => dummy.GiveExperience(),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("Target is not dead."));
        }
    }
}
