namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            XMLJsonAdapter adapter = new XMLJsonAdapter(library);
            Book book = adapter.GetOldestBook();
            System.Console.Write(book.ToString());
        }
    }
}