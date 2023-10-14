using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

Console.OutputEncoding = Encoding.UTF8;


var FileContent = File.ReadAllText("example.json");

var books = JsonSerializer.Deserialize<List<Book>>(FileContent);

foreach (var book in books)
{
   Console.WriteLine($"Publishing House Id: {book.PublishingHouseId}");
   Console.WriteLine($"Title: {book.Title}");
   Console.WriteLine($"Publishing House: {book.PublishingHouse.Name}, {book.PublishingHouse.Adress}, Id: {book.PublishingHouse.Id} \n");
}

public class PublishingHouse
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Adress { get; set; }
}

public class Book
{
    [JsonIgnore]
    public int PublishingHouseId { get; set; }
    [JsonPropertyName("Name")]
    public string Title { get; set; }
    public PublishingHouse PublishingHouse { get; set; }
}


