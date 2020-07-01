using NUnit.Framework;

namespace MarsRover.Test
{
    public class Tests
    {
        private const string InitialPosition = "1 2 N";
        private const string PlateauDimension = "3 3";

        private MarsRover _marsRover;

        [SetUp]
        public void SetUp()
        {
            _marsRover = new MarsRover(PlateauDimension);
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

            _marsRover = new MarsRover("5 5");

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

            _marsRover = new MarsRover("3 2");

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
        public void ShouldMoveRoverOfOnePosition()
        {
            const string ExpectedPosition = "1 3 N";

            var rover = _marsRover.MoveRover("M");

            Assert.AreEqual(ExpectedPosition,rover.position);
        }
    }
}