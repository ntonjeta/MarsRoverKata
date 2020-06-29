using NUnit.Framework;
using MarsRover;

namespace MarsRoverAcceptance
{
    public class Tests
    {
        private MarsRover.MarsRover _sut;

        [SetUp]
        public void Setup()
        {
            _sut = new MarsRover.MarsRover("5 5");
        }

        [Test]
        public void FirstRover()
        {
            _sut.position = "1 2 N";
            _sut.move("LMLMLMLMM");

            Assert.AreEqual(_sut.position, "1 3 N");
        }

        [Test]
        public void SecondRover()
        {
            _sut.position = "3 3 E";
            _sut.move("MMRMMRMRRM");

            Assert.AreEqual(_sut.position, "1 3 N");
        }
    }
}