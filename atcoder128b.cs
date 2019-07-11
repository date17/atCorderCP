using System;
using System.Collections.Generic;
using System.Linq;

// atcoder 128b 2/26m

namespace Atcoder128b
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var N = int.Parse(n);
            int I = 1;
            var shop = new List<Shop>();
            Shop baffa;
            int[] hikaku = new int[N];

            for (int i = 0; i < N; i++)
            {
                var value = Console.ReadLine();
                var sepa = value.Split(' ');
                shop.Add(new Shop(I, sepa[0], int.Parse(sepa[1])));
                I++;

            }
            foreach(var i in shop)
            {
                Console.WriteLine(i.Id);
            }

            var sort = shop.OrderBy(x => x.S).ToArray();

            for (int i = 0; i < N; i++)
            {


                for (int j = 1; i+j < N; j++)
                {
                    if (sort[i].S == sort[i+j].S && sort[i].Id != sort[i+j].Id)
                    {
                        if (sort[i].P < sort[i+j].P)
                        {
                            baffa = sort[i];
                            sort[i] = sort[i+j];
                            sort[i+j] = baffa;
                        }
                    }
                }


            }
            foreach (var shops in sort)
            {
                Console.WriteLine(shops.Id);
            }


        }
    }

    class Shop
    {
        public int Id { get; set; }
        public string S { get; set; }
        public int P { get; set; }

        public Shop(int id, string s, int p)
        {
            Id = id;
            S = s;
            P = p;
        }

    }


}
