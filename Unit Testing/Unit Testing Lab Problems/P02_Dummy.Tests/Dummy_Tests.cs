using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Dummy_Tests
    {
        [Test]
        public void Dummy_Health_Loses_When_Is_Attacked()
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
        public void Dummy_Throws_Exception_If_He_Dead()
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
        public void Dummy_Should_Give_XP_If_Dead()
        {
            // Arrange
            var dummy = new Dummy(0, 100);

            // Act 
            var experience = dummy.GiveExperience();

            // Assert
            Assert.That(experience, Is.EqualTo(100));
        }

        [Test]
        public void Dummy_Should_Not_Give_XP_If_Alive()
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
