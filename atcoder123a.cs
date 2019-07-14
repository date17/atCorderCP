using System;
using System.Collections.Generic;

// 123a

namespace atcoder123a
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();
            var hikaku = 0;
            var hiki = 0;

            for (int i = 0; i < 6; i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }

            for (int j = 1; j < 5; j++)
            {
                for (int n = 0; n < 5; n++)
                {
                    
                    if (list[j] - list[n] < 0)
                    {
                        hiki = -(list[j] - list[n]);
                    }
                    else
                    {
                        hiki = list[j] - list[n];
                    }

                    if (hiki > list[5])
                    {
                        Console.WriteLine(":(");
                        hikaku = 1;
                        break;
                        
                    }
                    
                }
                if(hikaku == 1)
                {
                    break;
                }
            }

                if (hikaku == 0)
                {
                    Console.WriteLine("Yay!");
                }

            }
        }
    }
