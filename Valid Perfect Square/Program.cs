using System;

namespace Valid_Perfect_Square
{

    /*
     * Given a positive integer num, write a function which returns True if num is a perfect square else False.
     * Note: Do not use any built-in library function such as sqrt.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPerfectSquare(2147483647));
        }

        public static bool IsPerfectSquare(int num)
        {
            long x = 2, remainder = 0, y = num;
            if (num > 1)
            {
                while (x < num)
                {
                    remainder = y % x;
                    y /= x;

                    if (x == y && remainder == 0)
                    {
                        return true;
                    }
                    else if (x * x > num)
                    {
                        return false;
                    }
                    y = num;
                    x++;
                }
            }

            return false;
        }
    }
}
