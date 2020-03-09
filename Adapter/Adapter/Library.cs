using System.IO;
using Adapter.XmlBookList;

namespace Adapter
{
    public class Library
    {
        private static readonly string FileName = Directory.GetCurrentDirectory() + "Books.xml";

        public static IXmlBookList GetBooksXml()
        {
            return XmlHelper.DeserializeFromFile<XmlBookList.XmlBookList>(FileName);
        }

        public static void SetBookList(IXmlBookList list)
        {
            XmlHelper.SerializeToXmlFile((XmlBookList.XmlBookList)list, FileName, true);
        }
    }
}
