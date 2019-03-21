using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSample
{
    class AudioMixer
    {
        public static String Fix(String result) {
            Console.WriteLine("Fixing: {0}", result);
            return "Fix " + result;
        }
    }
}
