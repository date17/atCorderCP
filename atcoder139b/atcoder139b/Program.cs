using System;
using System.Collections.Generic;

 // 12min

namespace atcoder139b
{
    class Program
    {
        static void Main(string[] args)
        {
            var value= Console.ReadLine();
            var sepaValue = value.Split(' ');
            var A = int.Parse(sepaValue[0]);
            var B = int.Parse(sepaValue[1]);

            int ans = 0;
            var count = 0;

            if (A >= B)
            {
                ans = 1;
                Console.WriteLine($"{ans}");
            }
            else
            {
                
                count = B - A;

                int newA = A - 1;
                ans++;

                while(count > 0)
                {
                    count -= newA;
                    ans++;
                }

                Console.WriteLine($"{ans}");
            }
            
        }
    }
}
