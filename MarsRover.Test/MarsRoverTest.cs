using NUnit.Framework;

namespace MarsRover.Test
{
    public class Tests
    {
        public static int[,] InitialPlatoue = {
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0},
            {0,0,0,0,0}
        };

        private Rover _sut;

        [Test]
        public void ShouldCreateRoverPlatoue()
        {
            _sut = new Rover("5 5");
            Assert.AreEqual(InitialPlatoue,_sut.plateau);
        }
    }
}