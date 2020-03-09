using Adapter.XmlBookList;

namespace Adapter
{
    public class Library
    {
        private const string FileName = "D:\\design patterns module\\design-patterns-tasks\\Adapter\\Adapter\\Books.xml";

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
