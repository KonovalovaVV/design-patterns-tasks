using System.Collections.Generic;

namespace Adapter
{
    public interface IJsonBookList
    {
        public List<JsonBook> Books { get; set; }
    }
}
