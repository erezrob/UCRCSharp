using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCRCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            UCR.DTW(args[0], args[1], int.Parse(args[2]), float.Parse(args[3]));
        }
    }
}
