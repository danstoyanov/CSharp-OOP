using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test_Weapon_Losing_Durability_After_Each_Attack()
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
        public void Test_Axe_Should_Throw_Exception_If_An_Attack_Is_Made_With_Broken_Weapon()
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
    }
}