using System;
   public class SumExample
    {
        public static void Main(string[] args)
        {
        int n, sum = 0, m;
            Console.WriteLine("Enter a Number");
        n = int.Parse(Console.ReadLine());
        while(n>0)
        {
            m = n % 10;
            sum = sum + m;
            n = n / 10;
        }
        Console.Write("Sum is= " + sum);
        }
    }

