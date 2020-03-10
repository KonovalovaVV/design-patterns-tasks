using System;
using System.Collections.Generic;
using Adapter.Book;
using Adapter.XmlBookList;

namespace Adapter
{
    public class Program
    {
        static void Main(string[] args)
        {
            IXmlBookList list = new XmlBookList.XmlBookList
            {
                Books = new List<XmlBook>
                {
                    new XmlBook
                    {
                        AuthorName = "Gambardella Matthew",
                        Id = "bk101",
                        Price = 25,
                        PublishDate = new DateTime(2015, 7, 20),
                        Description = "An in-depth look at creating applications with XML.",
                        Title = "XML Developer's Guide"
                    },
                    new XmlBook
                    {
                        AuthorName = "Ralls Kim",
                        Id = "bk102",
                        Price = 245,
                        PublishDate = new DateTime(1990, 7, 20),
                        Description =
                            "A former architect battles corporate zombies, an evil sorceress,and her own childhood to become queen of the world.",
                        Title = "Midnight Rain"
                    }
                }
            };

            Library.SetBookList(list);

            XmlBookAnalyzerAdapter adapter = new XmlBookAnalyzerAdapter(new BooksAnalyzer());
            var oldestBook = adapter.GetOldestBook(Library.GetBooksXml());
            Console.WriteLine(oldestBook.ToString());
        }
    }
}