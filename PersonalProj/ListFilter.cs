using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalProj
{
    public static class ListFilter
    {
        public static List<Tuple<int, int>> Filter(this List<Tuple<int, int>> tuples)
        {
            return tuples.Where(t => t.Item1 % 3 == 0 && t.Item2 % 5 == 0)
                         .Skip(20).ToList();
        }
    }
}
