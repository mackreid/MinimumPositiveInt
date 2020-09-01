using System;

namespace MinimumPositiveInt
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a1 = {4, 1, 2, 4, 5, 6, 5};
            int[] a2 = {12, 3, 4, 5, 1, 6, 7, 8, -34, -1, -4};
            int[] a3 = {-1, 0, 1};

            Console.WriteLine(MinPositiveInt.Solve(a1)); // Expect 3
            Console.WriteLine(MinPositiveInt.Solve(a2)); // Expect 2
            Console.WriteLine(MinPositiveInt.Solve(a3)); // Expect 2
        }
    }
}
