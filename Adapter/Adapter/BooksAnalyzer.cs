using System.Linq;

namespace Adapter
{
    public class BooksAnalyzer
    {
        public JsonBook GetOldestBook(IJsonBookList list)
        {
            return list.Books
                .OrderByDescending(b => b.PublishDate)
                .FirstOrDefault(); 
        }
    }
}