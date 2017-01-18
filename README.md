# Extension Methods For String
The class library ExtensionsForStrings contains extension methods **.ReplaceEmoticons()**,**.ToArmenian()**.
The first **.ReplaceEmoticons()** method allows you to replace codes with emoticons like this: </br>
: smile: -> :smile: </br>
:umberella: -> :closed_umbrella: </br>
:bad: -> :disappointed: </br>
:sun: -> :sunny: </br>
: moon: -> :moon: </br>
: cloud: -> :cloud:</br>
: heart: ->:heart:</br>
:->: -> :point_right:</br>
:<-: -> :point_left: </br>

## In command window the result is:
![result](https://github.com/marysahakyan/ExtensionsForString/blob/master/mygif.gif)

The second **.ToArmenian()** method allows you to convert latin letters into armenian.Examples for easy orienting:</br>
'kh' -> 'խ' </br>
'ts' -> 'ծ' </br>
'dz' -> 'ձ' </br>
'gh' -> 'ղ' </br>
'tsh' -> 'ճ' </br>
'sh' -> 'շ' </br>
'ch' -> 'չ' </br>
'ph' -> 'փ' </br>
'ev' -> 'և' etc</br> 
## In command window the result is:
![result](https://github.com/marysahakyan/ExtensionsForString/blob/master/toarm.gif)
##Here are trial code
```cs
using System;
using ExtensionsForString;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {      
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            
            Console.WriteLine("Input the text!");
            string str = Console.ReadLine();
            Console.WriteLine(str.ReplaceEmoticons());
            
            Console.WriteLine("Input latin text!");
            str=Console.ReadLine();
            Console.WriteLine(str.ToArenian());
        }
    }
}
```
