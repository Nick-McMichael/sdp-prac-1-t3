using System;
using System.Collections.Generic;

namespace Euler
{
    class Program
    {

        
        

        static void Main(string[] args)
        {

            int i = 20;

            while (i % 2 != 0 || i % 3 != 0 || i % 4 != 0 || i % 5 != 0 ||
                     i % 6 != 0 || i % 7 != 0 || i % 8 != 0 || i % 9 != 0 ||
                     i % 10 != 0 || i % 11 != 0 || i % 12 != 0 || i % 13 != 0 ||
                     i % 14 != 0 || i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
                     i % 18 != 0 || i % 19 != 0 || i % 20 != 0)
            {
                i += 20;
            }

            Console.WriteLine("The smallest number evenly divisible by 1 through 20 is: " +  i);

            Console.WriteLine($"The solution to Q13 is {SolveQ13Euler.SolveQ13()}\n\n");

            Console.WriteLine($"Problem 1: {Problem1.solve()}");
        }
    }

    class SolveQ13Euler
    {
        //Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        public static string SolveQ13()
        {
            int sumOfSquares = 0; int squareOfSums=0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                squareOfSums += i;
            }
            squareOfSums = squareOfSums * squareOfSums;
            return Convert.ToString(squareOfSums- sumOfSquares);

           


            
        }
    }

    class Problem1
    {
        public static int solve()
        {
            int ans = 0;
            List<int> list = new List<int>();

            for (int x = 0; x < 1000; x++)
            {
                if (x % 3 == 0 || x % 5 == 0)
                {
                    list.Add(x);
                }
            }

            for (int y = 0; y < list.Count; y++)
            {
                ans += list[y];
            }

            return ans;


        }
    }
}
