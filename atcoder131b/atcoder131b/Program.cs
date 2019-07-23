using System;
using System.Collections.Generic;
using System.Linq;


// atcoder131b

namespace atcoder131b
{
    class Program
    {
        static void Main(string[] args)
        {

            var taste = new List<int>();

            var value = Console.ReadLine();
            var lines = value.Split(' ');
            var N = int.Parse(lines[0]);
            var L = int.Parse(lines[1]);
            int Avs = 0;

            for(int i = 0; i < N; i++)
            {
                taste.Add(L + (i + 1) - 1);
            }

            var tasteAbs = new List<int>();

            for (int i = 0; i < N; i++)
            {
                tasteAbs.Add(Math.Abs(taste[i]));
            }

            var absMin = tasteAbs.Min();

            for(int i = 0; i < N; i++)
            {
                if(-absMin == taste[i] || absMin == taste[i])
                {
                    Avs = taste[i];
                }
            }

           
            var thingAp = taste.Sum();
        

                Console.WriteLine(thingAp - Avs);
         
        }
    }
}
