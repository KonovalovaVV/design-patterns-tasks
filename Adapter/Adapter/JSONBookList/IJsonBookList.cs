using System.Collections.Generic;
using Adapter.Book;

namespace Adapter.JSONBookList
{
    public interface IJsonBookList
    {
        public List<JsonBook> Books { get; set; }
    }
}
