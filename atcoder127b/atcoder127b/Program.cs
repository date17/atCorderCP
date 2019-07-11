using System;
using System.Collections.Generic;
using System.Linq;

// 18min

namespace atcoder127b
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var sepa = value.Split(' ');
            int r = int.Parse(sepa[0]);
            int D = int.Parse(sepa[1]);
            int X_zero = int.Parse(sepa[2]);

            Keisann keisann = new Keisann();

            var kekka = keisann.kekka(r, D, X_zero);

            foreach (var item in kekka)
            {
                Console.WriteLine(item);
            }

        }
    }

    class Keisann
    {
        public int[] kekka(int r, int d, int x)
        {
            var keisann_kekka = new List<int>();
            int use_x = x;
            int next_x;

            for (int i = 0; i < 10; i++)
            {
                next_x = (r * use_x) - d;
                keisann_kekka.Add(next_x);
                use_x = next_x;
            }

            

            return keisann_kekka.ToArray();
        }
    }
}
