using System;
using System.Text.RegularExpressions;

namespace Text_Regular_Expression
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = ":(.*?):";
            string lookup = "--;text in here;--";

            Regex rgxLookup = new Regex(pattern, RegexOptions.Singleline, TimeSpan.FromSeconds(1));
            Match mLookup = rgxLookup.Match(lookup);

            string found = mLookup.Groups[1].Value;

            System.Console.WriteLine(found);

            //timeout
        }
    }
}
