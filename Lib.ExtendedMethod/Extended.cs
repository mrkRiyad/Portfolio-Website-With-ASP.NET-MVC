using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchWebsite
{
    public static class Extended
    {
        public static string WordCount(this string paragraph, int wordNumber, string dot = "...")
        {
            string[] arr = paragraph.Split(' ');
            string[] limitedData = arr.Take(wordNumber).ToArray();
            string result = String.Join(" ", limitedData);
            if (arr.Count() > wordNumber)   
            {
                return result + dot;
            }
            else
            {
                return result;
            }
        }

        public static string IsPublic(this int bit)
        {
            if (bit == 1)   
            {
                return "Yes";
            }
            else if (bit == 0)  
            {
                return "No";
            }
            else
            {
                return "Not Define";
            }
        }
    }
}
