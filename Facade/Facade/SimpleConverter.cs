using Facade.Codec;

namespace Facade
{
    public class SimpleConverter
    {
        public VideoFile Convert(string filename, string format)
        {
            VideoFile videoFile = new VideoFile(filename);
            switch (format)
            {
                case ".oog":
                    videoFile.Codec = new OGGCodec();
                    break;
                case ".mpeg4":
                    videoFile.Codec = new MPEG4Codec();
                    break;
                default: 
                    videoFile.Codec = new MPEG4Codec();
                    break;
            }

            VideoConverter videoConverter = new VideoConverter();
            return videoConverter.Convert(videoFile, videoFile.Codec);
        }
    }
}
