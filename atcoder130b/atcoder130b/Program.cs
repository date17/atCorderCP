using System;
using System.Collections.Generic;


namespace atcoder130b
{
    class Program
    {
        static void Main(string[] args)
        {
            var nx = Console.ReadLine();
            var splinx = nx.Split(' ');

            var N = int.Parse(splinx[0]);
            var X = int.Parse(splinx[1]);

            var l = Console.ReadLine();
            var splil = l.Split(' ');

            var L = new List<int>();

            for(int i = 0; i < splil.Length; i++)
            {
                L.Add(int.Parse(splil[i]));
            }

            var bound = 0;
        }
    }
}
