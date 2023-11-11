class Program
{
    static void Main()
    {
        var tree = new ChristmasTree();
        var decorations = new Decorations();
        decorations.AddDecoration("star");
        decorations.AddDecoration("red ball");
        var garland = new Garland();

        decorations.SetComponent(tree);
        garland.SetComponent(decorations);

        garland.Info();
        garland.LightUp();

        Console.Read();
    }
}


abstract class Tree
{
    public abstract void Info();
}


class ChristmasTree : Tree
{
    public override void Info()
    {
        Console.WriteLine("Just a Christmas tree");
    }
}


abstract class Decorator : Tree
{
    protected Tree component;

    public void SetComponent(Tree component)
    {
        this.component = component;
    }

    public override void Info()
    {
        if (component != null)
        {
            component.Info();
        }
    }
}


class Decorations : Decorator
{
    private readonly List<string> decorations = new List<string>();

    public void AddDecoration(string decoration)
    {
        decorations.Add(decoration);
    }

    public override void Info()
    {
        base.Info();
        foreach (var decoration in decorations)
        {
            Console.WriteLine($"Added decoration: {decoration}");
        }
    }
}


class Garland : Decorator
{
    public void LightUp()
    {
        Console.WriteLine("Garland activated, tree shines");
    }

    public override void Info()
    {
        base.Info();
        Console.WriteLine("Added garland");
    }
}
