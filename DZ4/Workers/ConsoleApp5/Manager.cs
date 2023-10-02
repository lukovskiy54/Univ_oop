namespace WorkerApp;

class Manager : Worker
{
    private Random random;

    public Manager(string name) : base(name, "Менеджер")
    { 
        random = new Random();
    }

    public override void FillWorkDay()
    {
        for (int i = 0; i < random.Next(1,10); i++)
        {
            Call();
        }
        Relax();
        for (int i = 0; i < random.Next(1, 5); i++)
        {
            Call();
        }
    }
}
