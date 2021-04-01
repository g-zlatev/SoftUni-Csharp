using System;
using System.Linq;
using System.Text;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split('\\', '.').ToArray();
            string name = str[^2];
            string extension = str[^1];


            //int lastIndexOfSlash = str.LastIndexOf('\\');
            //int lastIndexOfDot = str.LastIndexOf('.');
            //int nameLength = Math.Abs(lastIndexOfSlash - lastIndexOfDot) -1;

            //string fileName = str.Substring(lastIndexOfSlash + 1, nameLength);
            //string extension = str.Substring(lastIndexOfDot + 1);

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
