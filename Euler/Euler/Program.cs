using System;

namespace Euler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The solution to Q13 is {SolveQ13Euler.SolveQ13()}\n\n");
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
}
