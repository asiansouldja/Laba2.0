using System;

namespace LABA2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            string s1 = Console.ReadLine();
            double x = double.Parse(s1);

            switch (x)
            {
                case 1:
                    Console.WriteLine("Red");
                    break;
                case 2:
                    Console.WriteLine("Orange");
                    break;
                case 3:
                    Console.WriteLine("Yellow");
                    break;
                case 4:
                    Console.WriteLine("Blue");
                    break;
                case 5:
                    Console.WriteLine("Purple");
                    break;
                case 6:
                    Console.WriteLine("Green");
                    break;
                case 7:
                    Console.WriteLine("Brown");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;

            }
            
            

        }
    }
}
