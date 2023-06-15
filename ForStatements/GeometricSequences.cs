namespace ForStatements
{
    public static class GeometricSequences
    {
        public static ulong GetGeometricSequenceTermsProduct(uint a, uint r, uint n)
        {
            ulong product = 1;

            for (uint i = 0; i < n; i++)
            {
                ulong term = a;

                for (uint j = 0; j < i; j++)
                {
                    term *= r;
                }

                product *= term;
            }

            return product;
        }

        public static ulong SumGeometricSequenceTerms(uint n)
        {
            uint firstTerm = 5;
            uint commonRatio = 3;

            ulong sum = 0;
            ulong term = firstTerm;

            for (uint i = 0; i < n; i++)
            {
                sum += term;
                term *= commonRatio;
            }

            return sum;
        }

        public static ulong CountGeometricSequenceTerms1(uint a, uint r, uint maxTerm)
        {
            ulong count = 0;
            ulong term = a;

            while (term <= maxTerm)
            {
                count++;
                term *= r;
            }

            return count;
        }

        public static ulong CountGeometricSequenceTerms2(uint a, uint r, uint n, uint minTerm)
        {
            ulong count = 0;

            for (uint i = 0; i < n; i++)
            {
                uint term = a * (uint)Math.Pow(r, i);

                if (term >= minTerm)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
