using System.Collections.Generic;
using Adapter.Book;

namespace Adapter.XMLBookList
{
    public class XmlBookList : IXmlBookList
    {
        public List<XMLBook> Books { get; set; }
    }
}