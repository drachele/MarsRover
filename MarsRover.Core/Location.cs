using System;

namespace MarsRover.Core
{
    public class Location : ILocation
    {
        public Location(int x, int y, string direction)
        {
            XPos = x;
            YPos = y;
            Heading = (Orientation)Enum.Parse(typeof(Orientation), direction);
        }

        public int XPos { get; set; }
        public int YPos { get; set; }
        public Orientation Heading { get; set; }
    }
}