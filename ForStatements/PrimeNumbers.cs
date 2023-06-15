namespace ForStatements
{
    public static class PrimeNumbers
    {
        public static bool IsPrimeNumber(uint n)
        {
            if (n < 2)
            {
                return false;
            }

            for (uint i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        public static ulong SumDigitsOfPrimeNumbers(int start, int end)
        {
            ulong sum = 0;

            for (int num = start; num <= end; num++)
            {
                if (num < 2)
                {
                    continue;
                }

                bool isPrime = true;

                for (int divisor = 2; divisor * divisor <= num; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    sum += (ulong)GetDigitSum(num);
                }
            }

            return sum;
        }

        public static int GetDigitSum(int num)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            return sum;
        }
    }
}
