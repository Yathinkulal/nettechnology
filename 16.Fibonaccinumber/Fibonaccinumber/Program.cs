using System;

namespace Exercises
{
    class FibonacciNumber
    {
        public static void Main(string[] args)
        {
            int n1 = 0, n2 = 1, n3, i, num;
            Console.WriteLine("Enetr the number of element :");
            num = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2 + " ");
            for (i = 2; i < num; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3 + " ");
                n1 = n2;
                n2 = n3;
            }
        }
    }
}
