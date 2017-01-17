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
            
        }
    }
}
