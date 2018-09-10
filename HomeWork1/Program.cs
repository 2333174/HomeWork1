using System;

namespace HomeWork1
{
    class P4
    {
        static void Main(string[] args)
        {
            string s = "";
            double m = 0;
            double n = 0.0;
            s = Console.ReadLine();
            m = Double.Parse(s);
            s = Console.ReadLine();
            n = Double.Parse(s);
            Console.WriteLine($"Result:{m*n}");
        }
    }
}
