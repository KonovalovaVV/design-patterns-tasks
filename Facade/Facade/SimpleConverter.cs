using System;
using Facade.Codec;

namespace Facade
{
    public class SimpleConverter
    {
        public readonly VideoConverter videoConverter = new VideoConverter();

        public VideoFile Convert(string filename, string format)
        {
            VideoFile videoFile = new VideoFile(filename, GetCodec(format));
            return videoConverter.Convert(videoFile, videoFile.Codec);
        }

        private ICodec GetCodec(string format)
        {
            switch (format)
            {
                case OGGCodec.Format:
                    return new OGGCodec();
                case MPEG4Codec.Format:
                    return new MPEG4Codec();
                default:
                    throw new Exception("Invalid format.");
            }
        }
    }
}
