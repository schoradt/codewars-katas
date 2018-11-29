using System;

namespace LibKatas
{
    public class Triangle
    {
        public static bool IsTriangle(int a, int b, int c)
        {
            if (a + b > c && a < c && b < c) {
                return true;
            }

            if (b + c > a && b < a && c < a)
            {
                return true;
            }

            if (c + a > b && a < b && c < b)
            {
                return true;
            }

            return false;
        }
    }
}
