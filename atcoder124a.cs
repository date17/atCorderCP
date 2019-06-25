using System;

// atCoder124a

namespace atcoder124a
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var lines = value.Split(' ');
            var A = int.Parse(lines[0]);
            var B = int.Parse(lines[1]);

            var coin = 0;
            for (int i = 0; i < 2; i++)
            {
                if (A < B)
                {
                    coin += B;
                    B--;
                }
                else
                {
                    coin += A;
                    A--;
                }
            }

            Console.WriteLine(coin);
        }

    }
}
