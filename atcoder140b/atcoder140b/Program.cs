using System;
using System.Collections.Generic;

// 60min
namespace atcoder140b
{
    class Program
    {
        static void Main(string[] args)
        {
            var N = int.Parse(Console.ReadLine());
            var a = Console.ReadLine();
            var b = Console.ReadLine();
            var c = Console.ReadLine();

            var As = a.Split(" ");
            var Bs = b.Split(" ");
            var Cs = c.Split(" ");

            var A = new int[N];
            var B = new int[N];
            var C = new int[N - 1];

            int i;

            for(i = 0; i < N; i++)
            {
                if(i == N - 1)
                {
                    A[i] = int.Parse(As[i]);
                    B[i] = int.Parse(Bs[i]);
                    break;
                }

                A[i] = int.Parse(As[i]);
                B[i] = int.Parse(Bs[i]);
                C[i] = int.Parse(Cs[i]);

                Console.WriteLine($"{A[i]}, {B[i]}, {C[i]}");
            }

            
            var totalTaste = 0;

            i = 0;
            var before = -1;
            do
            {
                var now = A[i]-1;

                if (i > 0)
                {
                     before = A[i - 1]-1;
                }


                totalTaste += B[now];

                if (now - before == 1)
                {
                    totalTaste += C[before];
                }

                i++;
            } while (i < N);
            

            Console.WriteLine($"{totalTaste}");
            

        }
    }

    class Food
    {
        public int Number { get; set; }
        public int Taste { get; set; }
        public int GoodTaste { get; set; }

        public Food(int number, int taste, int goodTaste)
        {
            Number = number;
            Taste = Taste;
            GoodTaste = goodTaste;
        }

        public Food(int number, int taste)
        {
            Number = number;
            Taste = taste;
            GoodTaste = 0;
        }
    }
}
