namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            XmlBookAnalyzerAdapter adapter = new XmlBookAnalyzerAdapter(library);
            JsonBook book = adapter.GetOldestBook();
            System.Console.Write(book.ToString());
        }
    }
}