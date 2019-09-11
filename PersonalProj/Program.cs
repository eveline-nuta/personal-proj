using System;

namespace PersonalProj
{
    class Program
    {
        static void Main(string[] args)
        {
            ListGenerator.Generate().ParseToTuple().Filter().ParseToString().Print();
        }
    }
}
