using System.Collections.Generic;
using Adapter.Book;

namespace Adapter.JsonBookList
{
    public interface IJsonBookList
    {
        public List<JsonBook> Books { get; set; }
    }
}
