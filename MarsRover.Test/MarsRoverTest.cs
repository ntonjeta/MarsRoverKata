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
    }
}