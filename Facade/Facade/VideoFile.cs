using Facade.Codec;

namespace Facade
{
    public class VideoFile
    {
        public string FileName;
        public ICodec Codec { get; set; } 

        public VideoFile(string fileName)
        {
            FileName = fileName;

            if(fileName.EndsWith(".mpeg4"))
                Codec = new MPEG4Codec();
            if(fileName.EndsWith(".oog"))
                Codec = new OGGCodec();
        }
    }
}
