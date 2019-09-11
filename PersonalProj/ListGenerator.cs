using System;
using System.Collections.Generic;

namespace PersonalProj
{
   public static class ListGenerator
    {
        public static List<int> Generate()
        {
            var rand = new Random();
            var result = new List<int>();

            for (int i = 0; i < 100; i++)
            {
                result.Add(rand.Next(1000));
            }
            return result;
        }
    }
}
