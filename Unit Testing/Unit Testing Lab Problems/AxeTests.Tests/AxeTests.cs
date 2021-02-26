using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestWeaponLosingDurabilityAfterEachAttack()
        {
            // Arrenge
            Axe axe = new Axe(10, 5);
            Dummy target = new Dummy(100, 500);

            // Act
            axe.Attack(target);

            // Assert
            Assert.That(axe.DurabilityPoints, Is.EqualTo(4));
        }

        [Test]
        public void TestAxeShouldThrowExceptionIfAnAttackIsMadeWithBrokenWeapon()
        {
            // Arrange
            Axe axe = new Axe(10, 0);
            Dummy target = new Dummy(100, 500);

            // Assert
            Assert.That(() => axe.Attack(target),
                Throws
                .InvalidOperationException
                .With
                .Message
                .EqualTo("Axe is broken."));
        }

        [Test]
        public void DummyHealthLosesWhenIsAttacked()
        {
            // Arrange
            var dummy = new Dummy(100, 500);
            var attackPoints = 99;

            // Act
            dummy.TakeAttack(attackPoints);

            // Assert
            Assert.That(dummy.Health, Is.EqualTo(1));
        }
    }
}