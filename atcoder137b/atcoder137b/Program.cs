using System;
using System.Collections.Generic;
using System.Linq;

 // 40min

namespace atcoder137b
{
    class Program
    {
        static void Main(string[] args)
        {
            var getValue = Console.ReadLine();
            var sepaValue = getValue.Split(' ');
            var K = int.Parse(sepaValue[0]);
            var X = int.Parse(sepaValue[1]);

            int[] stones = new int[2000001];

            for(int i = -1000000; i < 1000000; i++)
            {
                stones[i + 1000000] = i;
            }

            var center = stones[1000000 + X];

            for(int i = -(Math.Abs(K - 1)); i <= Math.Abs(K - 1); i++)
            {
                if(-1000000 <= center + i && center + i <= 1000000)
                {
                    Console.Write($"{center + i} ");

                }
            }



        }
    }
}
