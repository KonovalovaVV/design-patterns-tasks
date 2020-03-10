using System;
using Facade.Codec;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VideoFile videoFile = new VideoFile("video.oog");
            ICodec codec = new MPEG4Codec();
            VideoConverter videoConverter = new VideoConverter();
            VideoFile convertedVideoFile = videoConverter.Convert(videoFile, codec);
            Console.WriteLine("Converting using VideoConverter: ");
            Console.WriteLine(convertedVideoFile.FileName);

            SimpleConverter simpleConverter = new SimpleConverter();
            VideoFile simpleConvertedVideoFile = simpleConverter.Convert("video.oog", ".mpeg4");
            Console.WriteLine("Converting using SimpleConverter: ");
            Console.WriteLine(simpleConvertedVideoFile.FileName);
        }
    }
}