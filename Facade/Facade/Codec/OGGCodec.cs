using System.Collections.Generic;

namespace Facade.Codec
{
    public class OGGCodec: ICodec
    {
        public string Format { get; }

        public OGGCodec()
        {
            Format = ".ogg";
        }

        public List<int> Compress(VideoFile videoFile)
        {
            return new List<int>();
        }

        public VideoFile Decompress(string filename, List<int> pixels)
        {
            return new VideoFile(filename);
        }
    }
}
