using System;

// atcoder126a

namespace atcorder126a
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var lines = value.Split(' ');
            var N = int.Parse(lines[0]);
            var K = int.Parse(lines[1]);
            var s = Console.ReadLine();
            var S = new string[N];

            for(int i = 0; i < N; i++)
            {
                S[i] = s.Substring(i, 1);
            }

            S[K-1] = S[K-1].ToLower();

            foreach(var j in S)
            {
                Console.Write(j);
            }
            Console.WriteLine("\n");
            
            
            


            
        }
    }
}
