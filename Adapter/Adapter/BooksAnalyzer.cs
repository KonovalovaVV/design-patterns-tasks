using System.Linq;
using Adapter.Book;
using Adapter.JSONBookList;

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