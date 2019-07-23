using System;
using System.Collections.Generic;
using System.Linq;

// 19min
namespace atcoder125b
{
    class Program
    {
        static void Main(string[] args)
        {
            var nString = Console.ReadLine();
            var vString = Console.ReadLine();
            var cString = Console.ReadLine();

            var N = int.Parse(nString);
            var vSepa = vString.Split(' ');
            var cSepa = cString.Split(' ');

            var juellyes = new List<Juelly>();

            for(int i = 0; i < N; i++)
            {
                juellyes.Add(new Juelly(int.Parse(vSepa[i]), int.Parse(cSepa[i])));
            }

            var XY = 0;

            for(int j = 0; j < N; j++)
            {
                var xy = juellyes[j].V - juellyes[j].C;
                if (xy > 0)
                {
                    XY += xy;
                }
            }

            Console.WriteLine(XY);

        }
    }

    class Juelly
    {
        
        public int V { get; set; }
        public int C { get; set; }

        public Juelly(int v, int c)
        {
            V = v;
            C = c;
        }
    }
}
