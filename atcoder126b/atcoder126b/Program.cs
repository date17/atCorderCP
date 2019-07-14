using System;

// 17m
namespace atcoder126b
{
    class Program
    {
        static void Main(string[] args)
        {
            int yymmHikaku = 0;
            int mmyyHikaku = 0;

            var s = Console.ReadLine();

            var first = int.Parse(s.Substring(0, 2));
            var second = int.Parse(s.Substring(2, 2));

            if(0 < first && first < 13)
            {
                mmyyHikaku = 1;
            }

            if(0 < second && second < 13)
            {
                yymmHikaku = 1;
            }

            if(mmyyHikaku == 1 && yymmHikaku != 1)
            {
                Console.WriteLine("MMYY");
            }
            else if(mmyyHikaku != 1 && yymmHikaku == 1)
            {
                Console.WriteLine("YYMM");
            }
            else if(mmyyHikaku == 1 && yymmHikaku == 1)
            {
                Console.WriteLine("AMBIGUOUS");
            }
            else
            {
                Console.WriteLine("NA");
            }
        }
    }
}
