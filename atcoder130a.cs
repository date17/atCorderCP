using System;

// atcoder130a
namespace atcoder130a
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var str = value.Split(' ');

            var X = int.Parse(str[0]);
            var A = int.Parse(str[1]);
            if(X < A)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("10");
            }
        }
    }
}
