using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSample
{
    class File
    {
        public String FileName { get; set; }

        public File(string fileName)
        {
            this.FileName = fileName;
        }

        public void Save() {
            Console.WriteLine("File '{0}' have been saved.", this.FileName);
        }
    }
}
