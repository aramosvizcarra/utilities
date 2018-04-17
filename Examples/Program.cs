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

    public class Container
    {
        public ACollection CollA { get; set; }

        public ACollection CollB { get; set; }
    }

    public class ACollection
    {
        public ObservableCollection<A> Items { get; set; }
    }

    public class A
    {
        public string Name { get; set; }
        public string value { get; set; }
    }


    public class Test
    {
        public int x;
        public string name;
        public Test(int x)
        {
            this.x = x;

        }
        public Test(string name)
        {
            this.name = name;
        }

        public void DoSomething()
        {
            x++;
        }
        public void DoSomething(int x)
        {
            x += x;
        }
        public void ChangeName()
        {
            name = "bye";
        }
        public void ChangeName(string name)
        {
            name = "hello";
        }




    }

    public class ClassA
    {
        public SomeTypes MyType { get; set; }
        public List<ClassB> attr { get; set; }
    }

    public class ClassB
    {
        public string Name { get; set; }
        public List<AttributeMap> Maps { get; set; }
    }

    public class AttributeMap
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }

    public enum SomeTypes
    {
        Type1,
        Type2
    }
}
