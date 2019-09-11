using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalProj
{
    public static class Parser
    {
        public static IEnumerable<(int, int)> ParseToTuple(this IEnumerable<int> list)
        {
            return list.Select((value, index) => (value, index));
        }

        public static IEnumerable<(string, string)> ParseToString(this IEnumerable<(int, int)> tuples)
        {

            foreach (var tuple in tuples)
            {
                yield return (tuple.Item1.ToString(), tuple.Item2.ToString());
            }

        }
    }
}
