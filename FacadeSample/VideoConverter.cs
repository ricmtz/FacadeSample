using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeSample
{
    class VideoConverter
    {
        public File Convert(String fileName, String format) {
            ICodec destinationCodec;
            VideoFile file = new VideoFile(fileName);
            CodecFactory sourceCodec = CodecFactory.Extract(file);
            if(format == "mp4") {
                destinationCodec = new MPEG4CompressionCodec();
            } else {
                destinationCodec = new OggCompressionCodec();
            }
            String buffer = BitrateReader.Read(fileName, sourceCodec);
            String result = BitrateReader.Convert(buffer, destinationCodec);
            result = AudioMixer.Fix(result);
            return new File(result);            
        }
    }
}
