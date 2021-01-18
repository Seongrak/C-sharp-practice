using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public static class ExtensionMethods
    {
        public static int WordCount(this string str)//has to be static
        {
            var wordCount = str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return wordCount;
        }
    }
}
