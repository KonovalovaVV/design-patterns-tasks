using System.Collections.Generic;
using Adapter.Book;

namespace Adapter.XmlBookList
{
    public class XmlBookList : IXmlBookList
    {
        public List<XmlBook> Books { get; set; }
    }
}