using NUnit.Framework;

namespace MarsRover.Core.Tests
{
    [TestFixture]
    public class RoverTests
    {
        [Test]
        public void ctor_CreatesRover()
        {
            var rover = new Rover();
            Assert.NotNull(rover);
        }

        [Test]
        public void ctor_WhenGivenPlateau_CreatesRover()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau);
            Assert.NotNull(rover);
        }

        [Test]
        public void ctor_WhenGivenPlateau_CreatesRoverWithPlateau()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau);

            Assert.NotNull(rover.Plateau);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndDirection_CreatesRover()
        {
            var plateau = new Plateau(5, 5);
            var location = new Location(1, 2, "N");
            var rover = new Rover(plateau, location);

            Assert.NotNull(rover);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndDirection_CreatesRoverWithPlateau()
        {
            var plateau = new Plateau(5, 5);
            var location = new Location(1, 2, "N");
            var rover = new Rover(plateau, location);

            Assert.NotNull(rover.Plateau);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndDirection_CreatesRoverWithLocation()
        {
            var plateau = new Plateau(5, 5);
            var location = new Location(1, 2, "N");
            var rover = new Rover(plateau, location);

            Assert.NotNull(rover.Location);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndDirection_RoverLocationXPositionIsCorrect()
        {
            var plateau = new Plateau(5, 5);
            var location = new Location(1, 2, "N");
            var rover = new Rover(plateau, location);

            Assert.AreEqual(1, rover.Location.XPos);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndDirection_RoverLocationYPositionIsCorrect()
        {
            var plateau = new Plateau(5, 5);
            var location = new Location(1, 2, "N");
            var rover = new Rover(plateau, location);

            Assert.AreEqual(2, rover.Location.YPos);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndNorthDirection_RoverLocationHeadingIsCorrect()
        {
            var plateau = new Plateau(5, 5);
            var location = new Location(1, 2, "N");
            var rover = new Rover(plateau, location);

            Assert.AreEqual(Orientation.N, rover.Location.Heading);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndSouthDirection_RoverLocationHeadingIsCorrect()
        {
            var plateau = new Plateau(5, 5);
            var location = new Location(1, 2, "S");
            var rover = new Rover(plateau, location);

            Assert.AreEqual(Orientation.S, rover.Location.Heading);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndEastDirection_RoverLocationHeadingIsCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "E"));

            Assert.AreEqual(Orientation.E, rover.Location.Heading);
        }

        [Test]
        public void ctor_WhenGivenPlateauStartLocationAndWestDirection_RoverLocationHeadingIsCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "W"));

            Assert.AreEqual(Orientation.W, rover.Location.Heading);
        }

        [Test]
        public void Rover_FacingNorthAndGivenMoveInstruction_YPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "N"));

            rover.MoveForward();

            Assert.AreEqual(3, rover.Location.YPos);
        }

        [Test]
        public void Rover_FacingNorthAndGivenMoveInstruction_XPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "N"));

            rover.MoveForward();

            Assert.AreEqual(1, rover.Location.XPos);
        }

        [Test]
        public void Rover_FacingSouthAndGivenMoveInstruction_YPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "S"));

            rover.MoveForward();

            Assert.AreEqual(1, rover.Location.YPos);
        }

        [Test]
        public void Rover_FacingSouthAndGivenMoveInstruction_XPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "S"));

            rover.MoveForward();

            Assert.AreEqual(1, rover.Location.XPos);
        }

        [Test]
        public void Rover_FacingEastAndGivenMoveInstruction_XPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "E"));

            rover.MoveForward();

            Assert.AreEqual(2, rover.Location.XPos);
        }

        [Test]
        public void Rover_FacingEastAndGivenMoveInstruction_YPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "E"));

            rover.MoveForward();

            Assert.AreEqual(2, rover.Location.YPos);
        }

        [Test]
        public void Rover_FacingWestAndGivenMoveInstruction_XPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "W"));

            rover.MoveForward();

            Assert.AreEqual(0, rover.Location.XPos);
        }

        [Test]
        public void Rover_FacingWestAndGivenMoveInstruction_YPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(1, 2, "W"));

            rover.MoveForward();

            Assert.AreEqual(2, rover.Location.YPos);
        }

        [Test]
        public void Rover_FacingWestAtStartAndGivenMoveInstruction_XPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(0, 2, "W"));

            rover.MoveForward();

            Assert.AreEqual(0, rover.Location.XPos);
        }

        [Test]
        public void Rover_FacingEastAtLimitAndGivenMoveInstruction_XPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 2, "E"));

            rover.MoveForward();

            Assert.AreEqual(5, rover.Location.XPos);
        }

        [Test]
        public void Rover_FacingSouthAtBottomAndGivenMoveInstruction_YPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 0, "S"));

            rover.MoveForward();

            Assert.AreEqual(0, rover.Location.YPos);
        }

        [Test]
        public void Rover_FacingNorthAtTopLimitAndGivenMoveInstruction_YPosCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "N"));

            rover.MoveForward();

            Assert.AreEqual(5, rover.Location.YPos);
        }

        [Test]
        public void Rover_FacingNorthAndGivenLeftInstruction_OrientationCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "N"));

            rover.MoveLeft();

            Assert.AreEqual(Orientation.W, rover.Location.Heading);
        }

        [Test]
        public void Rover_FacingWestAndGivenLeftInstruction_OrientationCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "W"));

            rover.MoveLeft();

            Assert.AreEqual(Orientation.S, rover.Location.Heading);
        }

        [Test]
        public void Rover_FacingSouthAndGivenLeftInstruction_OrientationCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "S"));

            rover.MoveLeft();

            Assert.AreEqual(Orientation.E, rover.Location.Heading);
        }

        [Test]
        public void Rover_FacingEastAndGivenLeftInstruction_OrientationCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "E"));

            rover.MoveLeft();

            Assert.AreEqual(Orientation.N, rover.Location.Heading);
        }

        [Test]
        public void Rover_FacingNorthAndGivenRightInstruction_OrientationCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "N"));

            rover.MoveRight();

            Assert.AreEqual(Orientation.E, rover.Location.Heading);
        }

        [Test]
        public void Rover_FacingWestAndGivenRightInstruction_OrientationCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "W"));

            rover.MoveRight();

            Assert.AreEqual(Orientation.N, rover.Location.Heading);
        }

        [Test]
        public void Rover_FacingSouthAndGivenRightInstruction_OrientationCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "S"));

            rover.MoveRight();

            Assert.AreEqual(Orientation.W, rover.Location.Heading);
        }

        [Test]
        public void Rover_FacingEastAndGivenRightInstruction_OrientationCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, new Location(5, 5, "E"));

            rover.MoveRight();

            Assert.AreEqual(Orientation.S, rover.Location.Heading);
        }

        [Test]
        public void PrintLocation_WhenGivenRover_OutputIsCorrect()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, 5, 5, "E");

            Assert.AreEqual("5 5 E", rover.PrintLocation());
        }

        [Test]
        public void AcceptInstructions_WhenGivenStringOfInstructionsWithoutRightTurns_DrivesRover()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, 1, 2, "N");

            rover.AcceptInstructions("LMLMLMLMM");

            Assert.AreEqual("1 3 N", rover.PrintLocation());
        }

        [Test]
        public void AcceptInstructions_WhenGivenStringOfInstructionsWithoutLeftTurns_DrivesRover()
        {
            var plateau = new Plateau(5, 5);
            var rover = new Rover(plateau, 3, 3, "E");

            rover.AcceptInstructions("MMRMMRMRRM");

            Assert.AreEqual("5 1 E", rover.PrintLocation());
        }
    }
}
