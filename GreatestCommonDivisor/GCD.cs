// Ignore Spelling: GCD

namespace GreatestCommonDivisor
{
    public class GCD
    {
        public static long GCDAlgorithm(long a, long b)
        {
            while (b != 0)
            {
                long t = b;
                b = a % b; 
                a = t;
            }
            return a;
        }
    }
}
