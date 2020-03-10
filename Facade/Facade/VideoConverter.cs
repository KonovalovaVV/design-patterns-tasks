using Facade.Codec;

namespace Facade
{
    public class VideoConverter
    {
        public VideoFile Convert(VideoFile videoFile, ICodec codec)
        {
            videoFile.Codec = codec;
            return videoFile;
        }
    }
}
