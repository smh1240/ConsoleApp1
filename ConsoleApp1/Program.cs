using System;

namespace HelloWorld
{
    public static class Program
    {
        static void Main()
        {
            Console.WriteLine("inter a number:");
            int x = Convert.ToInt32(Console.ReadLine());
           double xy= metoodMath(x);
            Console.WriteLine(xy);
            Console.ReadKey();
        }
         static public double metoodMath (int number )
        {
            double y = Math.Sqrt(Math.Abs(number) + Math.Sqrt(Math.Abs(number)) + Math.Sqrt(Math.Abs(number)));
            return y;

        }
    }
}