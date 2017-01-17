# Extension Methods For String
The class library ExtensionsForStrings containd extension methods **ReplaceEmoticons()**,**ToArmenian()**.
The first **ReplaceEmoticons()** method allows you to replace codes with emoticons like this: </br>
:smile: -> :) </br>
:umberella: </br>
:bad: -> :( </br>
:sun: </br>
:moon: </br>
:cloud: </br>
:heart: </br>
:->: </br>
:<-: </br>
For using this class library is necessary to add using ExtensionsForString;.Here are trial code.
```cs
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
        }
    }
}
```
## In command window the result is:
![result](https://github.com/marysahakyan/ExtensionsForString/blob/master/mygif.gif)
