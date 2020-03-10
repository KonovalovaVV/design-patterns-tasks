using Facade.Codec;

namespace Facade
{
    public class VideoFile
    {
        public string FileName;
        public ICodec Codec { get; set; } 

        public VideoFile(string fileName, ICodec codec)
        {
            FileName = fileName;
            Codec = codec;
        }
    }
}
