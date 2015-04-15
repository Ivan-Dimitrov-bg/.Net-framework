using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddPrefiks
{
    class Program
    {
        static void Main(string[] args)
        {
            var files = Directory.GetFiles(@"D:\05.TEDTest", "*.mp4");
            //string prefix = "SomePrefix";
            int counter = 1;
            
            foreach (var file in files)
            {

                string newFileName = Path.Combine(Path.GetDirectoryName(file), (counter + "." + Path.GetFileName(file)));
                File.Move(file, newFileName);

                counter++;
            }
            
        }
    }
}
