using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSample
{
    class Program
    {
        static void Main(string[] args)
        {
            VideoConverter convertor = new VideoConverter();
            File mp4 = convertor.Convert("funny_clips", "mp4");
            Console.WriteLine();
            mp4.Save();
            Console.ReadKey();
        }
    }
}
