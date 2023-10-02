namespace ConsoleApp6;

class River : GeographicalObject
{
    private readonly double speed;

    private readonly double length;

    public River(double x, double y, string name, string description, double speed, double length) : base(x, y, name, description)
    {
        if (speed <= 0)
        {
            throw new ArgumentException($"\"{nameof(speed)}\" cannot be less or equal to zero", nameof(speed));
        }

        if (length <= 0)
        {
            throw new ArgumentException($"\"{nameof(length)}\" cannot be less or equal to zero", nameof(length));
        }

        this.speed = speed;
        this.length = length;
    }

    public override string GetInfo()
    {
        return base.GetInfo() + $"Speed = {this.speed} cm/sec" + "\n" + $"Length = {this.length} km\n";
    }
}
