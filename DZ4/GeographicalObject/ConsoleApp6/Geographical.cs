namespace ConsoleApp6;

abstract class GeographicalObject : IGeographicalObject
{
    public string Name { get; }

    public string Description { get; }

    public double X { get; }

    public double Y { get; }

    public GeographicalObject(double x, double y, string name, string description) 
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentException($"\"{nameof(name)}\" cannot be empty or contain only a space.", nameof(name));
        }

        if (string.IsNullOrWhiteSpace(description))
        {
            throw new ArgumentException($"\"{nameof(description)}\" cannot be empty or contain only a space.", nameof(description));
        }

        X = x;
        Y = y;
        Name = name;
        Description = description;
    }

    public virtual string GetInfo() 
    {
        return $"Coordinates = (x : {X}, y : {Y})\nName is {Name}\nDescription is {Description}\n";
    }
}
