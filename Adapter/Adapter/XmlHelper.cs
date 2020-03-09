using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Adapter
{
    public static class XmlHelper
    {
        public static T DeserializeFromFile<T>(string filename) where T : class
        {
            return DeserializeFromXmlString<T>(File.ReadAllText(filename));
        }

        public static T DeserializeFromXmlString<T>(string xml) where T : class
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            return (T)xmlSerializer.Deserialize(new StringReader(xml));
        }

        public static string SerializeToXmlString<T>(T xmlObject, bool useNamespaces = true)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            MemoryStream memoryStream = new MemoryStream();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(memoryStream, Encoding.UTF8);
            xmlTextWriter.Formatting = Formatting.Indented;

            if (useNamespaces)
            {
                XmlSerializerNamespaces xmlSerializerNamespaces = new XmlSerializerNamespaces();
                xmlSerializerNamespaces.Add("", "");
                xmlSerializer.Serialize(xmlTextWriter, xmlObject, xmlSerializerNamespaces);
            }
            else
            {
                xmlSerializer.Serialize(xmlTextWriter, xmlObject);
            }

            string output = Encoding.UTF8.GetString(memoryStream.ToArray());
            string byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());
            if (output.StartsWith(byteOrderMarkUtf8))
            {
                output = output.Remove(0, byteOrderMarkUtf8.Length);
            }

            return output;
        }

        public static void SerializeToXmlFile<T>(T xmlObject, string filename, bool useNamespaces = true)
        { 
            File.WriteAllText(filename, SerializeToXmlString<T>(xmlObject, useNamespaces));
        }
    }
}    