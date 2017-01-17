using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsForString;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Input the text!");
            //string str = Console.ReadLine();

            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine(str.ReplaceEmoticons());

            Console.WriteLine("Մուտքագրեք լատինատառ տեքստը");
            string str=Console.ReadLine();
            Console.WriteLine(str.ToArenian());


        }
    }
}
