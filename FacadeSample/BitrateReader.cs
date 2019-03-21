using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSample
{
    class BitrateReader
    {
        public static String Read(String fileName, CodecFactory sourceCodec) {
            Console.WriteLine("Reading file: {0},", fileName);
            return "Buffer " + fileName;
        }

        public static String Convert(String buffer, ICodec sourceCodec){
            Console.WriteLine("Converting: {0}", buffer);
            return "Convertion " + buffer;
        }
    }
}
