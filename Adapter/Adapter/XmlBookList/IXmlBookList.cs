using System.Collections.Generic;
using Adapter.Book;

namespace Adapter.XmlBookList
{
    public interface IXmlBookList
    {
        public List<XmlBook> Books { get; set; }
    }
}
