using System;
using System.Collections.Generic;

namespace PersonalProj
{
   public static class ListGenerator
    {
        public static IEnumerable<int> Generate()
        {
            var rand = new Random();

            for (int i = 0; i < 1000; i++)
            {
                yield return rand.Next(1000);
            }
        }
    }
}
