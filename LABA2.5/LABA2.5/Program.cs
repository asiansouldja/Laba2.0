using System;

namespace LABA2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            Console.Write("Enter n:"); 
            n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter m:");
            m = Int32.Parse(Console.ReadLine());
            int[,] x = new int[n, m];
            Console.Write("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    x[i, j] = int.Parse(Console.ReadLine());


                    Console.WriteLine(x[i, j]);
                }
             }


                double sum = 0;


                for (int i = 0; i < m; ++i)
                {


                    for (int j = 0; j < n; ++j)
                    {


                        if (x[i, j] < 0)
                        {
                            sum += x[i, j];
                        }

                    }


                }
                Console.WriteLine("Sum of negative: " + sum);
            }
        }
    }

