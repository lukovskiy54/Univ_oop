namespace WorkerApp;

class Program
{
    static void Main(string[] args)
    {
        Team RabbitSoft = new Team("RabbitSoft");
        Manager Ivan = new Manager("Ivan");
        Developer Lena = new Developer("Lena");
        Ivan.FillWorkDay();
        Lena.FillWorkDay();
        RabbitSoft.AddWorker(Ivan);
        RabbitSoft.AddWorker(Lena);
        Console.WriteLine(RabbitSoft.GetFullInfo());

    }
}