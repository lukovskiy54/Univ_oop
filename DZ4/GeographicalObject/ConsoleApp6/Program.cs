namespace ConsoleApp6;

class Program
{
    static void Main(string[] args)
    {
         
        Mountain Everest = new Mountain(5,6,"Everest", "The highest", 8849 );
        River Amazon = new River(3, 4, "Amazon", "The longest", 5.5, 6400);
        Console.WriteLine(Everest.GetInfo());
        Console.WriteLine(Amazon.GetInfo());
    }
}
