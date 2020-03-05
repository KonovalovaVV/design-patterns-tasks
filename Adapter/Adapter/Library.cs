using System;
using System.Xml;
using System.Collections.Generic;

namespace Adapter
{
    public class Library: IXmlBookList
    {
        private const string FileName = "Books.xml";
        public List<Book> Books { get; set; }

        public Library()
        {
            XmlDocument document = new XmlDocument();
            document.Load(FileName);
            ReadBooks(document);
        }

        private void ReadBooks(XmlDocument document)
        {
            Books = new List<Book>();
            XmlElement root = document.DocumentElement;
            foreach (XmlNode node in root)
            {
                Books.Add(GetBook(node));
            }
        }

        private Book GetBook(XmlNode node)
        {
            Book book = new Book();
            if (node.Attributes.Count > 0)
            {
                XmlNode attr = node.Attributes.GetNamedItem("id");
                if (attr != null)
                    book.Id = attr.Value;
            }
            foreach (XmlNode childnode in node.ChildNodes)
            {
                switch (childnode.Name)
                {
                    case "author":
                        book.AuthorName = childnode.InnerText;
                        break;
                    case "title":
                        book.Title = childnode.InnerText;
                        break;
                    case "price":
                        book.Price = Double.Parse(childnode.InnerText);
                        break;
                    case "publish_date":
                        book.PublishDate = DateTime.Parse(childnode.InnerText);
                        break;
                    case "description":
                        book.Description = childnode.InnerText;
                        break;
                }
            }

            return book;
        }

        public List<Book> GetBookXML()
        {
            return Books;
        }
    }
}
