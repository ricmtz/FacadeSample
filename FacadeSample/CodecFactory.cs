using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSample
{
    class CodecFactory
    {
        public String FileName { get; set; }

        public CodecFactory(string fileName)
        {
            this.FileName = fileName;
        }

        public static CodecFactory Extract(VideoFile file)
        {
            Console.WriteLine("Extracting: {0}", file.FileName);
            return new CodecFactory(file.FileName);
        }
    }
}
