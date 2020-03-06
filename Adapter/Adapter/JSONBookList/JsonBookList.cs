using System.Collections.Generic;
using Adapter.Book;

namespace Adapter.JSONBookList
{
    public class JsonBookList: IJsonBookList
    {
        public List<JsonBook> Books { get; set; }
    }
}
