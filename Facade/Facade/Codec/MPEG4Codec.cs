﻿using System.Collections.Generic;

namespace Facade.Codec
{
    public class MPEG4Codec: ICodec
    {
        public const string Format = "mpeg4";

        public List<int> Compress(VideoFile videoFile)
        {
            return new List<int>();
        }

        public VideoFile Decompress(string filename, List<int> pixels)
        {
            return new VideoFile(filename,this);
        }
    }
}
