using System.Collections.Generic;

namespace Facade.Codec
{
    public interface ICodec
    {
        public List<int> Compress(VideoFile videoFile);

        public VideoFile Decompress(string filename, List<int> pixels);
    }
}
