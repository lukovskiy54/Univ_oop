// Порушено принцип LSP, оскільки підтип Square не замінюваний базовим типом Rectangle. Можна вирішити так:
using System;
interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    private int _side;

    public int Side
    {
        get { return _side; }
        set { _side = value; }
    }

    public int GetArea()
    {
        return Side * Side;
    }
}

class Program
    {
        static void Main(string[] args)
        {
            IShape rect = new Square { Side = 5 };
            Console.WriteLine(rect.GetArea());
            Console.ReadKey();
        }
    }
}