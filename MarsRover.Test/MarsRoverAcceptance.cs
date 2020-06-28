using NUnit.Framework;
using MarsRover;

namespace MarsRoverAcceptance
{
    public class Tests
    {
        private Rover _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new Rover("5 5");
        }

        [Test]
        public void FirstRover()
        {
            _sut.initialPosition = "1 2 N";
            _sut.moves("LMLMLMLMM");

            Assert.AreEqual(_sut.getPosition(), "1 3 N");
        }

        [Test]
        public void SecondRover()
        {
            _sut.initialPosition = "3 3 E";
            _sut.moves("MMRMMRMRRM");

            Assert.AreEqual(_sut.getPosition(), "1 3 N");
        }
    }
}