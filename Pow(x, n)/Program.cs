using System;

namespace Pow_x__n_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MyPow(2,-2147483648));
        }
        // https://leetcode.com/problems/powx-n/discuss/19546/Short-and-easy-to-understand-solution

        static double MyPow(double x, int n)
        {
            if (n == 0) return 1;
            if (n == int.MinValue) return 0;
            if(n < 0)
            {
                n = -n;
                x = 1 / x;
            }

            return (n % 2 == 0) ? MyPow(x * x, n / 2) : x * MyPow(x * x, n / 2);
        }
    }
}
