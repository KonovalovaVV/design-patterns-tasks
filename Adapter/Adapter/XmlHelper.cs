using System.IO;
using System.Xml.Serialization;

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
            return (T)xmlSerializer.Deserialize(new StringReader(xml));
        }
    }
}    