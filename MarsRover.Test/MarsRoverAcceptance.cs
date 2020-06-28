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
            _sut.position = "1 2 N";
            _sut.moves("LMLMLMLMM");

            Assert.AreEqual(_sut.position, "1 3 N");
        }

        [Test]
        public void SecondRover()
        {
            _sut.position = "3 3 E";
            _sut.moves("MMRMMRMRRM");

            Assert.AreEqual(_sut.position, "1 3 N");
        }
    }
}