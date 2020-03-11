using System;
using Facade.Codec;

namespace Facade
{
    public class Program
    {
        public static void Main(string[] args)
        {
            VideoFile videoFile = new VideoFile("video.avi");
            VideoConverter videoConverter = new VideoConverter();
            VideoFile convertedVideoFile = videoConverter.Convert(videoFile, new MPEG4Codec());
            Console.WriteLine("Converting using VideoConverter: ");
            Console.WriteLine(convertedVideoFile.FileName);

            SimpleConverter simpleConverter = new SimpleConverter();
            VideoFile simpleConvertedVideoFile = simpleConverter.Convert("video.avi", OGGCodec.Format);
            Console.WriteLine("Converting using SimpleConverter: ");
            Console.WriteLine(simpleConvertedVideoFile.FileName);
        }
    }
}