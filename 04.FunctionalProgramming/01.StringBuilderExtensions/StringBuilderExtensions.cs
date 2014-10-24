using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace _01.StringBuilderExtensions
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public static class StringBuilderExtensions
    {
        public static string Substring(this StringBuilder str, int startIndex, int length)
        {
            string result = string.Empty;

            if (startIndex > 0 && length <= str.Length && startIndex <= str.Length)
            {
                for (int i = startIndex; i < length; i++)
                {
                    result += str[i];
                }
            }
            else
            {
                throw new ArgumentException("Invalid arguments!");  
            }

            return result;
        }

        public static StringBuilder RemoveText(this StringBuilder str, string text)
        {
            string tempStr = str.ToString().ToLower();
            string tempText = text.ToLower();
            
            while (tempStr.IndexOf(tempText) >= 0)
            {
                str.Remove(tempStr.IndexOf(tempText), tempText.Length);
                tempStr = tempStr.Substring(tempStr.IndexOf(tempText)+1);
            }   

            return str;
        }

        public static StringBuilder AppendAll<T>(this StringBuilder str, IEnumerable<T> items)
        {
            foreach (var item in items)
            {
                str.Append(item.ToString());
            }
            
            return str;
        }
    }
}
