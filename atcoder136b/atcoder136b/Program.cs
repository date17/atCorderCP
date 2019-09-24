using System;

//25min

namespace atcoder136b
{
    class Program
    {
        static void Main(string[] args)
        {
            var getValue = Console.ReadLine();
            var N = int.Parse(getValue);

            int ketaCount = 0;

            for (int i = 1; i <= N; i++)
            {
               if((0 < i && i < 10) || (100 <= i && i < 1000) || (10000 <= i && i < 100000))
                {
                    ketaCount++;
                }
            }

            Console.WriteLine($"{ketaCount}");
        }
    }
}
