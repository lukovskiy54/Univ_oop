namespace Converter;

class Program
{
    static void Main(string[] args)
    {
        Converter converter = new Converter(36M, 35M);

        Console.WriteLine("Enter your amount: ");

        decimal input = decimal.Parse(Console.ReadLine());

        Console.WriteLine("1. Convert UAH to USD");
        Console.WriteLine("2. Convert USD to UAH");
        Console.WriteLine("3. Convert UAH to EUR");
        Console.WriteLine("4. Convert EUR to UAH");
        Console.Write("Enter your choice (1-4): ");

        int type = int.Parse(Console.ReadLine());

        if (type == 1) 
        {
            Console.WriteLine("Your result is " + converter.ConvertUANToUSD(input) + " USD");
        }
        else if (type == 2)
        {
            Console.WriteLine("Your result is " + converter.ConvertUSDToUAN(input) + " UAN");
        }
        else if (type == 3)
        {
            Console.WriteLine("Your result is " + converter.ConvertUANToEUR(input) + " EUR");
        }
        else if (type == 4)
        {
            Console.WriteLine("Your result is " + converter.ConvertEURToUAN(input) + " UAN");
        }
        else
        {
            Console.WriteLine("Wrong input");
        }
    }
    }
}