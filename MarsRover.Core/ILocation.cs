namespace MarsRover.Core
{
    public interface ILocation
    {
        int XPos { get; set; }
        int YPos { get; set; }
        Orientation Heading { get; set; }
    }
}