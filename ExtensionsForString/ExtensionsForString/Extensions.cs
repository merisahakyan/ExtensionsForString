using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsForString
{
    public static class Extensions
    {
        public static bool IsContains(string str)
        {
            if (str.Contains(":smile:") || str.Contains(":cloud:") || str.Contains(":umberella:") || str.Contains(":bad:")
           || str.Contains(":sun:") || str.Contains(":moon:") || str.Contains(":heart:") || str.Contains(":->:") || str.Contains(":<-:"))
                return
                    true;
            else
                return false;
        }
        public static bool IsPalindrome(this string str)
        { bool t = true;
            for(int i=0;i<str.Length/2;i++)
                if(str[i]!=str[str.Length-i-1])
                {
                    t = false;
                    break;
                }
            return t;
        }
        public static string ReplaceEmoticons(this string str)
        {
            int index;
            while (IsContains(str))
            {
                if (str.Contains(":smile:"))
                {
                    index = str.IndexOf(":smile:");
                    str = str.Remove(index, 7);
                    str = str.Insert(index, "\u263A");
                }
                if (str.Contains(":cloud:"))
                {
                    index = str.IndexOf(":cloud:");
                    str = str.Remove(index, 7);
                    str = str.Insert(index, "\u2601");
                }
                if (str.Contains(":umberella:"))
                {
                    index = str.IndexOf(":umberella:");
                    str = str.Remove(index, 11);
                    str = str.Insert(index, "\u2602");
                }

                if (str.Contains(":bad:"))
                {
                    index = str.IndexOf(":bad:");
                    str = str.Remove(index, 5);
                    str = str.Insert(index, "\u2639");
                }
                if (str.Contains(":sun:"))
                {
                    index = str.IndexOf(":sun:");
                    str = str.Remove(index, 5);
                    str = str.Insert(index, "\u263C");
                }
                if (str.Contains(":moon:"))
                {
                    index = str.IndexOf(":moon:");
                    str = str.Remove(index, 6);
                    str = str.Insert(index, "\u263D");
                }
                if (str.Contains(":heart:"))
                {
                    index = str.IndexOf(":heart:");
                    str = str.Remove(index, 7);
                    str = str.Insert(index, "\u2665");
                }
                if (str.Contains(":<-:"))
                {
                    index = str.IndexOf(":<-:");
                    str = str.Remove(index, 4);
                    str = str.Insert(index, "\u261A");
                }
                if (str.Contains(":->:"))
                {
                    index = str.IndexOf(":->:");
                    str = str.Remove(index, 4);
                    str = str.Insert(index, "\u261B");
                }
            }
            return str;

        }

        public static string ToArenian(this string str)
        {
            str = str.ToLower();
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("a", "ա");
            dictionary.Add("b", "բ");
            dictionary.Add("g", "գ");
            dictionary.Add("d", "դ");
            dictionary.Add("e", "ե");
            dictionary.Add("z", "զ");
            dictionary.Add("@", "ը");
            dictionary.Add("th", "թ");
            dictionary.Add("i", "ի");
            dictionary.Add("l", "լ");
            dictionary.Add("kh", "խ");
            dictionary.Add("ts", "ծ");
            dictionary.Add("k", "կ");
            dictionary.Add("h", "հ");
            dictionary.Add("dz", "ձ");
            dictionary.Add("gh", "ղ");
            dictionary.Add("tsh", "ճ");
            dictionary.Add("m", "մ");
            dictionary.Add("y", "յ");
            dictionary.Add("n", "ն");
            dictionary.Add("sh", "շ");
            dictionary.Add("o", "ո");
            dictionary.Add("ch", "չ");
            dictionary.Add("p", "պ");
            dictionary.Add("j", "ջ");
            dictionary.Add("s", "ս");
            dictionary.Add("v", "վ");
            dictionary.Add("t", "տ");
            dictionary.Add("r", "ր");
            dictionary.Add("c", "ց");
            dictionary.Add("u", "ու");
            dictionary.Add("ph", "փ");
            dictionary.Add("q", "ք");
            dictionary.Add("ev", "և");
            dictionary.Add("f", "ֆ");
            dictionary.Add("vo", "ո");
            dictionary.Add(" ", " ");
            dictionary.Add(":", ":");
            string result = String.Empty;
            int i = 0;
            while (i < str.Length)
            {
                if (str[i] == 't' && str[i + 1] == 'h')
                {
                    result += dictionary["th"];
                    i+=2;
                    continue;
                }
                if (str[i] == 'k' && str[i + 1] == 'h')
                {
                    result += dictionary["kh"];
                    i+=2;
                    continue;
                }
                if (str[i] == 't' && str[i + 1] == 's')
                {
                    result += dictionary["ts"];
                    i+=2;
                    continue;
                }
                if (str[i] == 'd' && str[i + 1] == 'z')
                {
                    result += dictionary["dz"];
                    i+=2;
                    continue;
                }
                if (str[i] == 'g' && str[i + 1] == 'h')
                {
                    result += dictionary["gh"];
                    i+=2;
                    continue;
                }
                if (str[i] == 't' && str[i + 1] == 'h' && str[i + 2] == 's')
                {
                    result += dictionary["ths"];
                    i += 3;
                    continue;
                }
                if (str[i] == 's' && str[i + 1] == 'h')
                {
                    result += dictionary["sh"];
                    i+=2;
                    continue;
                }
                if (str[i] == 'c' && str[i + 1] == 'h')
                {
                    result += dictionary["ch"];
                    i+=2;
                    continue;
                }
                if (str[i] == 'p' && str[i + 1] == 'h')
                {
                    result += dictionary["ph"];
                    i+=2;
                    continue;
                }
                if (str[i] == 'e' && str[i + 1] == 'v')
                {
                    result += dictionary["ev"];
                    i+=2;
                    continue;
                    
                }
                if (str[i] == 'v' && str[i + 1] == 'o' && i == 0)
                {
                    result += dictionary["vo"];
                    i += 2;
                    continue;

                }

                result += dictionary[str[i].ToString()];
                i++;
            }
            return result;
        }
    }
}
