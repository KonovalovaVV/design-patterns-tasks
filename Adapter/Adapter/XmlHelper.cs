using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Adapter.Book;
using Adapter.XMLBookList;

namespace Adapter
{
    public static class XmlHelper
    {
        public static IXmlBookList DeserializeFromFile(string filename)
        {
            IXmlBookList books = new XmlBookList();
            XmlDocument document = new XmlDocument();
            document.Load(filename);
            XmlElement root = document.DocumentElement;
            XmlSerializer formatter = new XmlSerializer(typeof(XmlBook));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                books = (XmlBookList)formatter.Deserialize(fs);
            }

            return books;
        }
    }
}
