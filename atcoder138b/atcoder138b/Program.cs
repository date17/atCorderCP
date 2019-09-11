using System;
using System.Collections.Generic;

// 22min

namespace atcoder138b
{
    class Program
    {
        static void Main(string[] args)
        {
            var getN = Console.ReadLine();
            var getA = Console.ReadLine();

            var N = int.Parse(getN);
            var sepaA = getA.Split(' ');

            int[] A = new int[N];

            for(int i = 0; i < N; i++)
            {
                A[i] = int.Parse(sepaA[i]);

                
            }

            double bunbo = 0, ans = 0;

            for(int i = 0; i < N; i++)
            {
                bunbo += 1.0 / (double)A[i];
                
            }

            ans = 1.0 / bunbo;

            Console.WriteLine($"{ans:.00}");
        }
    }
}
