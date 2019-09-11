using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalProj
{
    public static class Printer
    {
        public static void Print(this IEnumerable<(string, string)> result)
        {
            foreach (var tuple in result)
            {
                Console.WriteLine(tuple.Item1 + "--" + tuple.Item2);
            }

        }
    }
}
