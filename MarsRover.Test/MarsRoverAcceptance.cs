using NUnit.Framework;
using MarsRover;

namespace MarsRoverAcceptance
{
    public class Tests
    {
        private RoverControl Control;

        [SetUp]
        public void Setup()
        {
            Control = new RoverControl("5 5");
        }

        [Test]
        public void FirstRover()
        {
            Control.PlaceRover(new Rover("1 2 N"));
            Control.MoveRover("LMLMLMLMM");

            Assert.AreEqual(Control.GetRoverPosition(), "1 3 N");
        }

        [Test]
        public void SecondRover()
        {
            Control.PlaceRover(new Rover("3 3 E"));
            Control.MoveRover("MMRMMRMRRM");

            Assert.AreEqual(Control.GetRoverPosition(), "1 3 N");
        }
    }
}