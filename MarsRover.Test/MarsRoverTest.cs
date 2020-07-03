using NUnit.Framework;
using MarsRover;

namespace MarsRover.Test
{
    public class Tests
    {
        private const string InitialPosition = "1 2 N";
        private const string PlateauDimension = "4 4";

        private RoverControl _marsRover;

        [SetUp]
        public void SetUp()
        {
            _marsRover = new RoverControl(PlateauDimension);
            _marsRover.PlaceRover(new Rover(InitialPosition));
        }

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

            _marsRover = new RoverControl("5 5");

            Assert.AreEqual(ExpectedPlateau, _marsRover.GetPlateau());
        }

        [Test]
        public void ShouldCreateRoverSpecifiedDimension()
        {
            int[,] ExpectedPlateau = {
                {0,0},
                {0,0},
                {0,0}
            };

            _marsRover = new RoverControl("3 2");

            Assert.AreEqual(ExpectedPlateau, _marsRover.GetPlateau());
        }

        [Test]
        public void ShoudlSetRoverInInitialPosition()
        {
            Assert.AreEqual(InitialPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShoudlRotateRoverToLeft()
        {
            const string ExpectedPosition = "1 2 O";

            var rover = _marsRover.MoveRover("L");

            Assert.AreEqual(ExpectedPosition, rover.position);
        }

        [Test]
        public void ShoudlRotateRoverToRigth()
        {
            const string ExpectedPosition = "1 2 E";

            var rover = _marsRover.MoveRover("R");

            Assert.AreEqual(ExpectedPosition, rover.position);
        }

        [Test]
        public void ShoudlRotateRoverTwoTimeToRigth()
        {
            const string ExpectedPosition = "1 2 S";

            var rover = _marsRover.MoveRover("RR");

            Assert.AreEqual(ExpectedPosition, rover.position);
        }

        [Test]
        public void ShoudlRotateRoverTwoTimeToLeft()
        {
            const string ExpectedPosition = "1 2 S";

            var rover = _marsRover.MoveRover("LL");

            Assert.AreEqual(ExpectedPosition, rover.position);
        }

        [Test]
        public void ShoudlRotateRoverAndReturnToInitialPosition()
        {
            var rover = _marsRover.MoveRover("RL");

            Assert.AreEqual(InitialPosition, rover.position);
        }

        [Test]
        public void ShoudlMakeCompleteRotationAndReturnToInitialPosition()
        {
            var rover = _marsRover.MoveRover("RRRR");

            Assert.AreEqual(InitialPosition, rover.position);
        }

        [Test]
        public void ShouldMoveRoverOfOnePosition()
        {
            const string ExpectedPosition = "1 3 N";

            var rover = _marsRover.MoveRover("M");

            Assert.AreEqual(ExpectedPosition,rover.position);
        }

        [Test]
        public void ShouldMoveRoverOfTwoPosition()
        {
            const string ExpectedPosition = "1 4 N";

            var rover = _marsRover.MoveRover("MM");

            Assert.AreEqual(ExpectedPosition,rover.position);
        }

        [Test]
        public void ShouldRotateAndMoveRover()
        {
            const string ExpectedPosition = "0 2 O";

           var rover = _marsRover.MoveRover("LM");

            Assert.AreEqual(ExpectedPosition,rover.position);
        }
    }
}