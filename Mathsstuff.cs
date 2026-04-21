using System.Runtime.InteropServices.Marshalling;

namespace MathUtils
{
    public class MathsUtil
    {
        public static double Factorial(int n)
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

        
        public static bool primeCheck(int n)
        {
            bool prime = false;
            double num2 = n - 1;

            double numFact = MathsTools.factoral(num2);
            double num3 = numFact + 1;

            if (num3 % n == 0)
            {
                prime = true;
            }

            return prime;
        }

        public static string EvenCheck(int n)
        {
            if (n%2 == 0)
            {
                return "Number is even";
            }
            return "Number is odd";
        }

        public static double Power(int baseNum, int exp)
        {
            double result = baseNum;

            for (int i = 1; i < exp; i++)
            {
                result*= baseNum;
            }
            if (exp == 0)
            {
                result = 1;
            }
             
            return result;
        }

        public static int DigitCount(int n)
        {
            string final = Convert.ToString(n);
            return final.Length;
        }

        public static bool isDivisible(int n, int divisor)
        {
            bool divisible = false;

            if (n %  divisor == 0)
            {
                divisible = true;
            }

            return divisible;
        }

        public static double degsToRads(double degs)
        {
            double rads = (degs/360)*2*(Math.PI);

            return rads; 
    
        }

        public static double DegSin(double x)
        {
            double sinx;

            x = (MathsTools.degsToRads(x));

            sinx = x;

            for (int i = 3; i < 70; i += 4)
            {
                sinx -= ((MathsUtil.Power(x, i)) / (MathsUtil.Factorial(i)));
                sinx += ((MathsUtil.Power(x, i + 2)) / (MathsUtil.Factorial(i + 2)));
            }

            return Math.Round(sinx, 3);
    
        }

        public static double nCr(double n, double r)
        {
            double nCr = (MathsUtil.Factorial(n))/ ((MathsUtil.Factorial(n - r))*MathsUtil.Factorial(r));
            return nCr;
        }

        /*public static int ReverseNumber(int n)
        {

        }*/
    }
}
