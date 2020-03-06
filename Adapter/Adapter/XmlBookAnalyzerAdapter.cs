using Adapter.XMLBookList;
using Adapter.Book;
using Adapter.JSONBookList;
 
namespace Adapter
{
    public class XmlBookAnalyzerAdapter 
    {
        private readonly BooksAnalyzer _analyzer;

        public XmlBookAnalyzerAdapter(BooksAnalyzer analyzer)
        {
            _analyzer = analyzer;
        }

        public JsonBook GetOldestBook(IXmlBookList list)
        {
            var jsonBookList = ConvertXmlToJsonList(list);
            var result = _analyzer.GetOldestBook(jsonBookList);

            return result;
        }

        private IJsonBookList ConvertXmlToJsonList(IXmlBookList list)
        {
            IJsonBookList jsonBooks = new JsonBookList();
            foreach (XMLBook xmlBook in list.Books)
            {
                JsonBook jb = new JsonBook();
                jb.AuthorName = xmlBook.AuthorName;
                jb.Id = xmlBook.Id;
                jb.Price = xmlBook.Price;
                jb.PublishDate = xmlBook.PublishDate;
                jb.Description = xmlBook.Description;
                jb.Title = xmlBook.Title;
                jsonBooks.Books.Add(jb);
            }

            return jsonBooks;
        }
    }
}
