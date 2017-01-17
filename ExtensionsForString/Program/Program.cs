using System;
using ExtensionsForString;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the text!");
            string str = Console.ReadLine();

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(str.ReplaceEmoticons());

            Console.WriteLine("Մուտքագրեք լատինատառ տեքստը");
            str=Console.ReadLine();
            Console.WriteLine(str.ToArenian());


        }
    }
}
