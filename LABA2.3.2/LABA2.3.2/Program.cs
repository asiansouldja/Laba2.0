using System;

namespace LABA2._3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5];

            Random random = new Random();
            int dob = 1;
            
            
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(-100,100);
                

                    Console.WriteLine(a[i]);
                
                }
            for (int i = 0; i < a.Length; i++) if (a[i] < 0)
                {
                    if (a[i] < 0)
                    {
                        dob *= a[i];
                    }
                }

            int min;
            int sumN = 0;
            int res = 0;
            min = a[0];
            for (int i = 0; i < a.Length - 1; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                    sumN = i;
                }
            }
            for (int i = sumN + 1; i < a.Length; i++)
            {
                res += a[i];
            }


            Console.WriteLine("Dob:" + dob);
            Console.WriteLine("Sum:" + res);
            



        }
    }
}
