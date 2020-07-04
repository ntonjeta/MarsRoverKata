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

            _marsRover.MoveRover("L");

            Assert.AreEqual(ExpectedPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShoudlRotateRoverToRigth()
        {
            const string ExpectedPosition = "1 2 E";

            _marsRover.MoveRover("R");

            Assert.AreEqual(ExpectedPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShoudlRotateRoverTwoTimeToRigth()
        {
            const string ExpectedPosition = "1 2 S";

            _marsRover.MoveRover("RR");

            Assert.AreEqual(ExpectedPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShoudlRotateRoverTwoTimeToLeft()
        {
            const string ExpectedPosition = "1 2 S";

            _marsRover.MoveRover("LL");

            Assert.AreEqual(ExpectedPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShoudlRotateRoverAndReturnToInitialPosition()
        {
            _marsRover.MoveRover("RL");

            Assert.AreEqual(InitialPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShoudlMakeCompleteRotationAndReturnToInitialPosition()
        {
            _marsRover.MoveRover("RRRR");

            Assert.AreEqual(InitialPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShouldMoveRoverOfOnePosition()
        {
            const string ExpectedPosition = "1 3 N";

            _marsRover.MoveRover("M");

            Assert.AreEqual(ExpectedPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShouldRotateLeftAndMoveRover()
        {
            const string ExpectedPosition = "0 2 O";

            _marsRover.MoveRover("LM");

            Assert.AreEqual(ExpectedPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShouldRotateRigthAndMoveRover()
        {
            const string ExpectedPosition = "2 2 E";

            _marsRover.MoveRover("RM");

            Assert.AreEqual(ExpectedPosition, _marsRover.GetRoverPosition());
        }

        [Test]
        public void ShouldRotateTwoTimeAndMove()
        {
            const string ExpectedPosition = "1 1 S";

            _marsRover.MoveRover("RRM");

            Assert.AreEqual(ExpectedPosition, _marsRover.GetRoverPosition());
        }
    }
}