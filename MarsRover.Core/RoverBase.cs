namespace MarsRover.Core
{
    public abstract class RoverBase
    {
        protected RoverBase()
        {
        }

        protected RoverBase(IPlateau plateau)
        {
            Plateau = plateau;
        }

        protected RoverBase(IPlateau plateau, ILocation location)
        {
            Plateau = plateau;
            Location = location;
        }

        public IPlateau Plateau { get; private set; }
        public ILocation Location { get; private set; }

        public abstract void MoveForward();
        public abstract void MoveLeft();
        public abstract void MoveRight();

        public string PrintLocation()
        {
            return string.Format("{0} {1} {2}", Location.XPos, Location.YPos, Location.Heading);
        }

        public void AcceptInstructions(string instructions)
        {
            foreach (var instruction in instructions.ToUpper())
            {
                if (instruction.Equals('M'))
                    MoveForward();
                else if (instruction.Equals('L'))
                    MoveLeft();
                else if (instruction.Equals('R'))
                    MoveRight();
            }
        }
    }
}