using NUnit.Framework;

namespace MarsRover.Core.Tests
{
    [TestFixture]
    public class PlateauTests
    {
        [Test]
        public void ctor_CreatesPlateau()
        {
            var plateau = new Plateau();
            Assert.NotNull(plateau);
        }

        [Test]
        public void ctor_CreatesPlateauWithCorrectXMin()
        {
            var plateau = new Plateau();
            Assert.AreEqual(0, plateau.XMin);
        }

        [Test]
        public void ctor_CreatesPlateauWithCorrectYMin()
        {
            var plateau = new Plateau();
            Assert.AreEqual(0, plateau.YMin);
        }

        [Test]
        public void ctor_CreatesPlateauWithCorrectMinY()
        {
            var plateau = new Plateau();
            Assert.NotNull(plateau);
        }

        [Test]
        public void ctor_WhenGivenPlateauSize_CreatesPlateau()
        {
            var plateau = new Plateau(5, 5);
            Assert.NotNull(plateau);
        }

        [Test]
        public void ctor_WhenGivenPlateauSize_HasCorrectXDimension()
        {
            var plateau = new Plateau(5, 5);
            Assert.AreEqual(5, plateau.XMax);
        }

        [Test]
        public void ctor_WhenGivenPlateauSize_HasCorrectYDimension()
        {
            var plateau = new Plateau(5, 5);
            Assert.AreEqual(5, plateau.YMax);
        }
    }
}
