using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Text.Json;
using Newtonsoft.Json.Linq;

namespace Adapter
{
    public class XMLJsonAdapter 
    {
        private readonly Library _library;
        public List<Book> Books { get; set; } 

        public XMLJsonAdapter(Library library)
        {
            _library = library;
        }

        public Book GetOldestBook()
        {
            using (FileStream fs = new FileStream("Books.json", FileMode.OpenOrCreate))
            {
                //JsonSerializer js = new JsonSerializer();
                //JsonWriter jw = new JTokenWriter();
                foreach (Book book in _library.Books)
                {
                    // js.Serialize(new JTokenWriter(), book);
                    string json = System.Text.Json.JsonSerializer.Serialize<Book>(book);
                }
            }
            return (new BooksAnalyzer()).GetOldestBook();
        }
    }
}
