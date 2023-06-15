namespace ForStatements
{
    public static class Factorial
    {
        public static int GetFactorial(int n)
        {
            int factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            return factorial;
        }

        public static int SumFactorialDigits(int n)
        {
            int factorial = GetFactorial(n);
            int sum = 0;

            for (; factorial != 0; factorial /= 10)
            {
                int digit = factorial % 10;
                sum += digit;
            }

            return sum;
        }
    }
}
