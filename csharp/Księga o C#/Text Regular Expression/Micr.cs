using System;
using System.Text.RegularExpressions;

namespace Text_Regular_Expression
{
    class Micr
    {
        static void micr()
        {
            string input = "int[] values = { 1, 2, 3 };\n" +
                     "for (int ctr = values.GetLowerBound(1); ctr <= values.GetUpperBound(1); ctr++)\n" +
                     "{\n" +
                     "   Console.Write(values[ctr]);\n" +
                     "   if (ctr < values.GetUpperBound(1))\n" +
                     "      Console.Write(\", \");\n" +
                     "}\n" +
                     "Console.WriteLine();\n";   
      
            string pattern = @"Console\.Write(Line)?";
            MatchCollection matches = Regex.Matches(input, pattern);
            foreach (Match match in matches)
                Console.WriteLine("'{0}' found in the source code at position {1}.",  
                                match.Value, match.Index);
            // The example displays the following output:
            //    'Console.Write' found in the source code at position 112.
            //    'Console.Write' found in the source code at position 184.
            //    'Console.WriteLine' found in the source code at position 207.
        }
    }
}