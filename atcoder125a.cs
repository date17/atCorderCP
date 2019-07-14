using System;

// atcoder125a

namespace atcoder125a
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var lines = value.Split(' ');
            var A = int.Parse(lines[0]);
            var B = int.Parse(lines[1]);
            var T = int.Parse(lines[2]);
            var bisuket = 0;

            var minute = 1;
            while((T + 0.5) > (minute * A))
            {
                bisuket += B;
                minute++;
            }

            Console.WriteLine(bisuket);
        }
    }
}
