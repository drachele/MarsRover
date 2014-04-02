namespace MarsRover.Core
{
    public class Rover : RoverBase
    {
        public Rover()
        {
        }

        public Rover(IPlateau plateau)
            : base(plateau)
        {
        }

        public Rover(IPlateau plateau, ILocation location) : base(plateau, location)
        {
        }

        public Rover(IPlateau plateau, int startX, int startY, string direction)
            : base(plateau, new Location(startX, startY, direction))
        {
        }

        public override void MoveForward()
        {
            switch (Location.Heading)
            {
                case Orientation.N:
                    if (Location.YPos < Plateau.YMax)
                        Location.YPos++;
                    break;
                case Orientation.S:
                    if (Location.YPos > 0)
                        Location.YPos--;
                    break;
                case Orientation.E:
                    if (Location.XPos < Plateau.XMax)
                        Location.XPos++;
                    break;
                case Orientation.W:
                    if (Location.XPos > 0)
                        Location.XPos--;
                    break;
            }
        }

        public override void MoveLeft()
        {
            switch (Location.Heading)
            {
                case Orientation.N:
                    Location.Heading = Orientation.W;
                    break;
                case Orientation.W:
                    Location.Heading = Orientation.S;
                    break;
                case Orientation.S:
                    Location.Heading = Orientation.E;
                    break;
                case Orientation.E:
                    Location.Heading = Orientation.N;
                    break;
            }
        }

        public override void MoveRight()
        {
            switch (Location.Heading)
            {
                case Orientation.N:
                    Location.Heading = Orientation.E;
                    break;
                case Orientation.W:
                    Location.Heading = Orientation.N;
                    break;
                case Orientation.S:
                    Location.Heading = Orientation.W;
                    break;
                case Orientation.E:
                    Location.Heading = Orientation.S;
                    break;
            }
        }
    }
}