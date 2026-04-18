using System.Runtime.InteropServices.Marshalling;

namespace MyUtils
{
    public class Numbers
    {
        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            int total = 1;
            for (int i = 1; i <= n; i++)
            {
                total = total * i;
            }
            return total;
        }
        public static string Prime(int n)
        {
            if (n <= 1)
            {
                return "The number is not a prime";
            }
            
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return "The number is NOT a prime";
                    
                }
                
            }
            return "The number is a prime";

        }

        public static string EvenCheck(int n)
        {
            if (n%2 == 0)
            {
                return "Number is even";
            }
            return "Number is odd";
        }

        public static int Power(int baseNum, int exp)
        {
            int result = 1;
            if (baseNum == 0)
            {
                return 0;
            }

            for (int i = 0; i < exp; i++)
            {
                result *= baseNum;
            }
            return result;
        }

        public static int DigitCount(int n)
        {
            string final = Convert.ToString(n);
            return final.Length;
        }

        /*public static int ReverseNumber(int n)
        {

        }*/
    }
}
