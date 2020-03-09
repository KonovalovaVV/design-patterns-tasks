using System.IO;
using System.Xml;
using System.Xml.Serialization;
using Adapter.Book;

namespace Adapter
{
    public static class XmlHelper
    {
        public static T DeserializeFromFile<T>(string filename) where T : class, new()
        {
            T books;
            XmlDocument document = new XmlDocument();
            document.Load(filename);
            XmlSerializer formatter = new XmlSerializer(typeof(XmlBook));
            using (FileStream fs = new FileStream(filename, FileMode.OpenOrCreate))
            {
                books = (T)formatter.Deserialize(fs);
            }

            return books;
        }
    }
}
