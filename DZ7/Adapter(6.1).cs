public interface IWord2028
{
    void OpenDocx(string file);
}
public class Word2003
{
    public void OpenDoc(string filename)
    {
        Console.WriteLine($"Opening doc file : {filename}");
    }
}
public class WordAdapter : IWord2028
{
    private readonly Word2003 _oldword;
    public WordAdapter(Word2003 oldword)
    {
        _oldword = oldword;
    }

    public void OpenDocx(string file)
    {
        _oldword.OpenDoc(file);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Word2003 word2003 = new Word2003();
        IWord2028 word2028 = new WordAdapter(word2003);
        word2028.OpenDocx("file.doc");
    }
}
   