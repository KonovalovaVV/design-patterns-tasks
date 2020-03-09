using System.Collections.Generic;
using Adapter.Book;
using Adapter.JsonBookList;
using Adapter.XmlBookList;

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
            return  _analyzer.GetOldestBook(jsonBookList);
        }

        private IJsonBookList ConvertXmlToJsonList(IXmlBookList list)
        {
            IJsonBookList jsonBooks = new JsonBookList.JsonBookList();
            jsonBooks.Books = new List<JsonBook>();
            foreach (XmlBook xmlBook in list.Books)
            {
                jsonBooks.Books.Add(ConvertXmlToJsonBook(xmlBook));
            }

            return jsonBooks;
        }

        private JsonBook ConvertXmlToJsonBook(XmlBook xmlBook)
        {
            JsonBook jb = new JsonBook
            {
                AuthorName = xmlBook.AuthorName,
                Id = xmlBook.Id,
                Price = xmlBook.Price,
                PublishDate = xmlBook.PublishDate,
                Description = xmlBook.Description,
                Title = xmlBook.Title
            };
            return jb;
        }
    }
}
