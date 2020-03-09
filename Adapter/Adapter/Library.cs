using Adapter.XMLBookList;

namespace Adapter
{
    public class Library
    {
        private const string FileName = "Books.xml";

        public static IXmlBookList GetBooksXml()
        {
            return XmlHelper.DeserializeFromFile(FileName);
        }
    }
}
