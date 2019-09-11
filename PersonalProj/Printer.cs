using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalProj
{
    public static class Printer
    {
        public static void Print(this List<Tuple<string, string>> result)
        {
            foreach (Tuple<string, string> tuple in result)
            {
                Console.WriteLine(tuple.Item1 + "--" + tuple.Item2);
            }

        }
    }
}
