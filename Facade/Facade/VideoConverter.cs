using System.Linq;
using Facade.Codec;

namespace Facade
{
    public class VideoConverter
    {
        public VideoFile Convert(VideoFile videoFile, ICodec codec)
        {
            videoFile.FileName = videoFile.FileName.Remove(videoFile.FileName.Length - videoFile.Codec.Format.Length);
            videoFile.FileName += codec.Format;
            videoFile.Codec = codec;
            return videoFile;
        }
    }
}
