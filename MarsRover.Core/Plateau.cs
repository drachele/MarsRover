namespace MarsRover.Core
{
    public class Plateau : IPlateau
    {
        public Plateau()
        {
            XMin = 0;
            YMin = 0;
        }

        public Plateau(int x, int y)
        {
            XMax = x;
            YMax = y;
        }

        public int XMax { get; private set; }
        public int YMax { get; private set; }
        public int XMin { get; private set; }
        public int YMin { get; private set; }
    }
}