using System.Xml;
using Adapter.XMLBookList;
using Adapter.Book;
using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    public class Library
    {
        private const string FileName = "Books.xml";

        public IXmlBookList GetBooksXML()
        {
            IXmlBookList books = new XmlBookList();
            XmlDocument document = new XmlDocument();
            document.Load(FileName);
            XmlElement root = document.DocumentElement;
            XmlSerializer formatter = new XmlSerializer(typeof(XMLBook));
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                books = (XmlBookList)formatter.Deserialize(fs);
            }

            return books;
        }
    }
}
