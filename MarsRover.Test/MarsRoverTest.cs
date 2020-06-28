using NUnit.Framework;

namespace MarsRover.Test
{
    public class Tests
    {

        private Rover _sut;

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

            _sut = new Rover("5 5");

            Assert.AreEqual(ExpectedPlateau, _sut.plateau);
        }

        [Test]
        public void ShouldCreateRoverSpecifiedDimension()
        {
            int[,] ExpectedPlateau = {
                {0,0},
                {0,0},
                {0,0}
            };

            _sut = new Rover("3 2");

            Assert.AreEqual(ExpectedPlateau, _sut.plateau);
        }
    }
}