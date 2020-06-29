using NUnit.Framework;

namespace MarsRover.Test
{
    public class Tests
    {
        private MarsRover _sut;

        [Test]
        public void ShouldCreateRoverFiveSquarePlatoue()
        {
            int[,] ExpectedPlateau = {
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0},
                {0,0,0,0,0}
            };

            _sut = new MarsRover("5 5");

            Assert.AreEqual(ExpectedPlateau, _sut.GetPlateau());
        }

        [Test]
        public void ShouldCreateRoverSpecifiedDimension()
        {
            int[,] ExpectedPlateau = {
                {0,0},
                {0,0},
                {0,0}
            };

            _sut = new MarsRover("3 2");

            Assert.AreEqual(ExpectedPlateau, _sut.GetPlateau());
        }

        [Test]
        public void ShoudlSetRoverInInitialPosition()
        {
            _sut = new MarsRover("3 3");

            _sut.position = "1 2 N";

            Assert.AreEqual("1 2 N", _sut.position);
        }

        [Test]
        public void ShoudlRotateRoverToLeft()
        {
            _sut = new MarsRover("3 3");
            _sut.position = "1 2 N";

            _sut.move("L");

            Assert.AreEqual("1 2 O", _sut.position);
        }

        [Test]
        public void ShoudlRotateRoverToRigth()
        {
            _sut = new MarsRover("3 3");
            _sut.position = "1 2 N";

            _sut.move("R");

            Assert.AreEqual("1 2 E", _sut.position);
        }
    }
}