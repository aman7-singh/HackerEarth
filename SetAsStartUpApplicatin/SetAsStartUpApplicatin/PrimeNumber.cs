using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerEarth
{
    public class PrimeNumber
    {
        public static string PrintPrimeNumber(int number)
        {
            string primeNum = string.Empty;
            bool isNotPrime = false; int j;
            for (int i = 2; i <= number; i++)
            {
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isNotPrime = true;
                        break;
                    }
                }
                if (!isNotPrime)
                {
                    primeNum = $"{j} ";
                }
                else
                    isNotPrime = false;
            }
            
            return primeNum;
        }

    }
}
