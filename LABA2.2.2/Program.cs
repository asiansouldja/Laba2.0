using System;

namespace LABA2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double y = 0, x = 0, a = 0, b = 6, dx = 0.5;
            Console.WriteLine("|   x         y  |");
            while (x <= b && x >= a) {
                y = 1 / (1 - Math.Sqrt(x));
                if (x == 1)
                {
                    Console.WriteLine("CANT DIVIDE ON 0");
                }
                else if (x < 0)
                {
                    Console.Write("SQRT CANT BE NEAGTIVE");
                }
                else

                    Console.WriteLine("  {0}         {1}    ", x, Math.Round(y, 2)); // заокруглення до 2 знаків після коми
                x = x + dx;
            }
        }
    }
}
