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
            return DeserializeFromXmlString<T>(File.ReadAllText(filename));
        }
        public static T DeserializeFromXmlString<T>(string xml) where T : new()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            StringReader stringReader = new StringReader(xml);
            var xmlObject = (T)xmlSerializer.Deserialize(stringReader);
            return xmlObject;
        }
    }
}
//
//<catalog xmlns = "urn:oasis:names:tc:entity:xmlns:xml:catalog" >