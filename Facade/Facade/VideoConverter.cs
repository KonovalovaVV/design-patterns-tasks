using System;
using System.IO;
using Facade.Codec;

namespace Facade
{
    public class VideoConverter
    {
        public VideoFile Convert(VideoFile videoFile, ICodec codec)
        {
            // some magic
            var processedFileName = Path.ChangeExtension(videoFile.FileName, GetFileExtension(codec));

            return new VideoFile(processedFileName);
        }

        private string GetFileExtension(ICodec codec)
        {
            switch (codec)
            {
                case MPEG4Codec mpeg4:
                    return MPEG4Codec.DefaultFileExtension;
                case OGGCodec ogg:
                    return OGGCodec.DefaultFileExtension;
                case null:
                    throw new ArgumentNullException(nameof(codec));
                default:
                    throw new Exception("Codec is not supported.");
            }
        }
    }
}
