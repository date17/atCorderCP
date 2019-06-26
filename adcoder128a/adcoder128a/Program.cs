using System;

// dcoder128a

namespace adcoder128a
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine().Split(' ');

            var tree = int.Parse(value[0]);
            var Apple = int.Parse(value[1]);

            Apple = (Apple) + tree * 3;

            int pay = Apple / 2;

            Console.WriteLine(pay);
        }
    }
}
