using System;
using Facade.Codec;

namespace Facade
{
    public class SimpleConverter
    {
        private readonly VideoConverter _videoConverter = new VideoConverter();

        public VideoFile Convert(string filename, string format)
        {
            return _videoConverter.Convert(new VideoFile(filename), GetCodec(format));
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
