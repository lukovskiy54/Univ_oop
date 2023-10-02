namespace WorkerApp;
using System.Text;

class Team 
{
    private string name;

    private List<Worker> workers;

    public Team(string name) 
    {
        this.name = name;
        workers = new ();
    }

    public void AddWorker(Worker worker)
    {
        workers.Add(worker);
    }

    public string GetInfo() =>
        new StringBuilder()
            .AppendLine("Назва команди: " + name)
            .AppendJoin("\n", workers.Select((worker, index) => (index + 1) + ". " + worker.Name))
            .ToString();
        
    public string GetFullInfo()
    {
        string result = "Назва команди: " + name + "\n";
        result += string.Join("\n", workers.Select((worker, index) => { 
            return (index + 1) + ". " + worker.Name + " - " + worker.Position + " - " + worker.WorkDay;
        }));
        return result;
    }
}