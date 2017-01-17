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

            string str = "Hiii :smile: :cloud: :bad: :sun: :moon: :heart: :->: :<-: :sun: :sun: :heart:";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine(str.ReplaceEmoticons());

        }
    }
}
