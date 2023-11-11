public class CoolingSystem
{
    public void StartCoolingSystem()
    {
        Console.WriteLine("Setting up cooling system");
    }
    public void TurnOffCooling()
    {
        Console.WriteLine("Cooling system turned off");
    }
}

public class Processor
{
    public void Start()
    {
        Console.WriteLine("Processor started");
    }
    public void Shutdown()
    {
        Console.WriteLine("Processor shutdown");
    }
}

public class Memory
{
    public void LoadData()
    {
        Console.WriteLine("Data loaded into memory");
    }
    public void ClearMemory()
    {
        Console.WriteLine("Memory cleared");
    }
}

public class HardDrive
{
    public void ReadData()
    {
        Console.WriteLine("Reading data from disk");
    }
    public void WriteData()
    {
        Console.WriteLine("Writing data to disk");
    }
}

public class Monitor
{
    public void MonitorOn()
    {
        Console.WriteLine("Monitor is working");
    }
    public void MonitorOff()
    {
        Console.WriteLine("Monitor is not working now");
    }
}

public class ComputerFacade
{
    private readonly CoolingSystem _coolingSystem;
    private readonly Processor _processor;
    private readonly Memory _memory;
    private readonly HardDrive _hardDrive;
    private readonly Monitor _monitor;

    public ComputerFacade()
    {
        _coolingSystem = new CoolingSystem();
        _processor = new Processor();
        _memory = new Memory();
        _hardDrive = new HardDrive();
        _monitor = new Monitor();
    }

    public void StartComputer()
    {
        _coolingSystem.StartCoolingSystem();
        _processor.Start();
        _memory.LoadData();
        _hardDrive.ReadData();
        _monitor.MonitorOn();
        Console.WriteLine("Computer started successfully.");
        _hardDrive.WriteData();
    }

    public void ShutdownComputer()
    {
        _memory.ClearMemory();
        _processor.Shutdown();
        _coolingSystem.TurnOffCooling();
        _monitor.MonitorOff();
        Console.WriteLine("Computer shut down.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var computer = new ComputerFacade();
        computer.StartComputer();
        computer.ShutdownComputer();
    }
}