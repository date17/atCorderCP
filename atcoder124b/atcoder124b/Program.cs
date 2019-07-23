using System;

//18min
namespace atcoder124b
{
    class Program
    {
        static void Main(string[] args)
        {
            var nString = Console.ReadLine();
            var hString = Console.ReadLine();

            var N = int.Parse(nString);
            var hSepa = hString.Split(' ');

            var ryokan = 1;
            var hikaku = 0;

            for (int i = 1; i < N; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (int.Parse(hSepa[j]) <= int.Parse(hSepa[i]))
                    {
                        hikaku = 1;
                    }
                    else
                    {
                        hikaku = 0;
                        break;
                    }
                }

                if(hikaku == 1)
                {
                    ryokan++;
                }
            }

            Console.WriteLine(ryokan);
        }
    }
}
