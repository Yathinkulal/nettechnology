using System;

namespace Exercises

{
    class Graycode
    {
        static int getGray(int n)
        {
            return n ^ (n >> 1);
        }
        static void Main(string[] args)
        {

            int InputNum, GrayNum;
            Console.WriteLine("\n Enter the decimal number");
            InputNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Binary equivalant of {0}:{1}", InputNum, Convert.ToString(InputNum, 2));


            Console.WriteLine("\n Gray code equivalant of {0}:{1}", InputNum, Convert.ToString(InputNum, 2));


        }
    }
}