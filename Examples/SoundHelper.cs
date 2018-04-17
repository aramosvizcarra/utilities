using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examples
{
    public class SoundHelper
    {
        public static void ConvertMp3ToWav(string mp3, string wav)
        {
            using (var reader = new Mp3FileReader(mp3))
            {
                
                WaveFileWriter.CreateWaveFile(wav, reader);
            }
        }
    }
}
