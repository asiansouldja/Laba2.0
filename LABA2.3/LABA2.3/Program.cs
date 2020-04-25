using System;

namespace LABA2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, dob = 1;
            Console.Write("Enter n:"); //n = suma elementiv massiva
            n = Int32.Parse(Console.ReadLine());
            int[] x = new int[n];
            Console.Write("Enter elements:");
            for (int i = 0; i < n; i++) x[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++) if (x[i] < 0)
                {
                    
                    dob *= x[i];
                    

                }
            int min;
            int sumN = 0;
            int res = 0;
            min = x[0];
            for (int i = 0; i < x.Length - 1; i++)
            {
                if (x[i] < min)
                {
                    min = x[i];
                    sumN = i;
                }
            }
            for (int i = sumN + 1; i < x.Length; i++)
            {
                res += x[i];
            }
            Console.WriteLine("Dob of negative elements: " + dob);
            Console.WriteLine("Sum after first negative: " + res);
            Console.ReadKey();
        }
        
    }
    }

