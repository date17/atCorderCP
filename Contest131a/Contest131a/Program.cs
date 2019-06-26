using System;

namespace Contest131a
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new int[4];
            var hikaku = 0;
           for(int i = 0; i < 4; i++)
            {
                s[i] = Console.Read();
            }
           for(int n = 0; n < 3; n++)
            {
                if(s[n] == s[n + 1])
                {
                    Console.WriteLine($"入力しづらい");
                    hikaku = 1;
                    break;
                }
            }
            if (hikaku == 0)
            {
                Console.WriteLine("good");
            }
        }
    }
}
