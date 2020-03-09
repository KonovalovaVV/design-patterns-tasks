using System.Collections.Generic;
using Adapter.Book;

namespace Adapter.JsonBookList
{
    public class JsonBookList: IJsonBookList
    {
        public List<JsonBook> Books { get; set; }
    }
}
