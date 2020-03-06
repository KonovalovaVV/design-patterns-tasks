using System.Collections.Generic;
using Adapter.Book;

namespace Adapter.XMLBookList
{
    public interface IXmlBookList
    {
        public List<XMLBook> Books { get; set; }
    }
}
