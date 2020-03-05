using System;
using System.Xml;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace Adapter
{
    public class Library: IXmlBookList
    {
        private const string FileName = "Books.xml";
        public List<XMLBook> Books { get; set; }

        public Library()
        {
            XmlDocument document = new XmlDocument();
            document.Load(FileName);
            ReadBooks(document);
        }

        private void ReadBooks(XmlDocument document)
        {
            Books = new List<XMLBook>();
            XmlElement root = document.DocumentElement;
            XmlSerializer formatter = new XmlSerializer(typeof(XMLBook));
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                Books = (List<XMLBook>)formatter.Deserialize(fs);
            }
        }

        private XMLBook GetBook(XmlNode node, XmlSerializer formatter)
        {
            XMLBook book;
            using (FileStream fs = new FileStream(FileName, FileMode.OpenOrCreate))
            {
                book = (XMLBook)formatter.Deserialize(fs);
            }
            return book;
        }

        public List<XMLBook> GetBookXML()
        {
            return Books;
        }
    }
}
