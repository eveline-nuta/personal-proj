using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonalProj
{
    public static class Parser
    {
        public static List<Tuple<int, int>> ParseToTuple(this List<int> list)
        {
            var tuples = new List<Tuple<int, int>>();
            //doing the same thing twice
            foreach (var item in list.Select((value, index) => (value, index)))
            {
                var value = item.value;
                var index = item.index;

                var tuple = new Tuple<int, int>(index, value);
                tuples.Add(tuple);
            }

            return tuples;
        }
        public static List<Tuple<string, string>> ParseToString(this List<Tuple<int, int>> tuples)
        {
            var parsedTuples = new List<Tuple<string, string>>();

            foreach (var tuple in tuples)
            {
                var parsedTuple = new Tuple<string, string>
                    (tuple.Item1.ToString(), tuple.Item2.ToString());

                parsedTuples.Add(parsedTuple);
            }

            return parsedTuples;
        }
    }
}
