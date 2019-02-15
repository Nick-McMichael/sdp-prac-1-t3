using System;
using System.Collections.Generic;

namespace Euler
{
    class Program
    {

        
        

        static void Main(string[] args)
        {


            Console.WriteLine($"Problem 1: {Problem1.solve()}");
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
