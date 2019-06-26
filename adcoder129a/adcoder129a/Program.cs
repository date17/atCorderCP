using System;
using System.Linq;

// adcoder129a

namespace adcoder129a
{
    class Program
    {
        static void Main(string[] args)
        {
            var value = Console.ReadLine();
            var minute = value.Split(' ');
            var P = int.Parse(minute[0]);
            var Q = int.Parse(minute[1]);
            var R = int.Parse(minute[2]);

            var total = new int[3];
            total[0] = P + Q;
            total[1] = P + R;
            total[2] = Q + R;

            var min = total.Min();

            Console.WriteLine(min);

        }
    }
}
