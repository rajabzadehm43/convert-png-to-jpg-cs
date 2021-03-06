using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;


namespace Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var folder = @"E:\آت و آشغال\png2jpg";
            int count = 0;

            foreach (string file in Directory.GetFiles(folder))
            {
                string ext = Path.GetExtension(file).ToLower();
                if (ext == ".png")
                {
                    Console.WriteLine(file);
                    string name = Path.GetFileNameWithoutExtension(file);
                    string path = Path.GetDirectoryName(file);

                    Image png = Image.FromFile(file);

                    png.Save(path + @"/" + name + ".jpg", ImageFormat.Jpeg);
                    png.Dispose();

                    count++;
                    File.Delete(file);

                }
            }

            Console.WriteLine("{0} file(s) converted.", count);
            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();
        }


    }
}
