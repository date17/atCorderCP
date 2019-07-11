using System;


// atcoder 127a

namespace adcoder127a
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var lines = value.Split(' ');
            var A = int.Parse(lines[0]);
            var B = int.Parse(lines[1]);

            if(A < 13)
            {
                Console.WriteLine($"{B / 2}");
            }
            else
            {
                Console.WriteLine($"{B}");
            }
        }
    }
}
