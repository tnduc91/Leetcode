using System;

namespace leetcode
{
    public class ReverseInteger
    {
        public static int Reverse(int x)
        {
            var res = 0;
            var isPositive = x > 0;
            if (!isPositive) x = -x;

            var lastDigit = isPositive ? 8 : 7;
            var safe = Int32.MaxValue / 10;

            while (x > 0)
            {
                var temp = x % 10;
                x = x / 10;
                
                if (res > safe)
                {
                    return 0;
                }
                if (res == safe)
                {
                    if (temp > lastDigit)
                    {
                        return 0;
                    }
                }

                res = res * 10 + temp;
            }

            res = isPositive ? res : -res;

            return res;
        }
    }
}