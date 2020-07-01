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
            _sut.PlaceRover(new Rover("1 2 N"));
            _sut.MoveRover("LMLMLMLMM");

            Assert.AreEqual(_sut.GetRoverPosition(), "1 3 N");
        }

        [Test]
        public void SecondRover()
        {
            _sut.PlaceRover(new Rover("3 3 E"));
            _sut.MoveRover("MMRMMRMRRM");

            Assert.AreEqual(_sut.GetRoverPosition(), "1 3 N");
        }
    }
}