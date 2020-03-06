namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            XmlBookAnalyzerAdapter adapter 
                = new XmlBookAnalyzerAdapter(new BooksAnalyzer());
        }
    }
}