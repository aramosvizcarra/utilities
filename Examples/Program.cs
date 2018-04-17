using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            //ImagingHelper.ConvertToIcon(@"C:\Users\aramos\Documents\horizant\logos\large.png", 
            //    @"C:\Users\aramos\Documents\horizant\logos\small_32x32.ico",
            //    32, true);

            //SoundHelper.ConvertMp3ToWav(@"C:\Users\aramos\Downloads\Pacman-death-sound.mp3", @"C:\Users\aramos\Downloads\Pacman-death-sound.wav");
            try
            {
                byte[] bytes = System.IO.File.ReadAllBytes(@"C:\Users\aramos\Documents\clients\bgis\A12103 04 test\A12103 04 test\a1210304sad-fn.json.zlib");
                byte[] outBytes;
                ZlibHelper.DecompressData(bytes, out outBytes);
                var str = System.Text.Encoding.Default.GetString(outBytes);
                System.IO.File.WriteAllText(@"C:\Users\aramos\Documents\clients\bgis\A12103 04 test\A12103 04 test\a1210304sad-fn.json", str);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }

    }

     

    
}
