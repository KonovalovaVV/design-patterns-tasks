namespace Adapter
{
    public class XmlBookAnalyzerAdapter 
    {
        private readonly Library _library;
        public IJsonBookList JsonBooks;
        public XmlBookAnalyzerAdapter(Library library)
        {
            _library = library;
        }

        public JsonBook GetOldestBook()
        {
           foreach(IBook book in _library.Books)
           {
                JsonBooks.Books.Add((JsonBook)book);
           }
           return new BooksAnalyzer().GetOldestBook(JsonBooks);
        }
    }
}
