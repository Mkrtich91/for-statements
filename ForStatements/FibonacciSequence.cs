using System.Net.Http.Headers;

namespace ForStatements
{
    public static class FibonacciSequence
    {
        public static int GetFibonacciNumber(int n)
        {
            if (n <= 0)
            {
            return 0;
            }

            if (n == 1 || n == 2)
            {
                return 1;
            }

            int fibNMinus2 = 1;
            int fibNMinus1 = 1;
            int fibN = 0;

            for (int i = 3; i <= n; i++)
            {
                fibN = fibNMinus2 + fibNMinus1;
                fibNMinus2 = fibNMinus1;
                fibNMinus1 = fibN;
            }

            return fibN;
        }

        public static ulong GetProductOfFibonacciNumberDigits(ulong n)
        {
            if (n != 0)
            {
                int fibN = GetFibonacciNumber((int)n);
                ulong product = 1;

                while (fibN > 0)
                {
                    ulong digit = (ulong)(fibN % 10);
                    product *= digit;
                    fibN /= 10;
                }

                return product;
            }
            else
            {
                return 0;
            }
        }
    }
}
