using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Kata
{
    public class SumOfDigits
    {
        //Given n, take the sum of the digits of n
        //If that value has more than one digit, continue reducing in this way until a single-digit number is produced.
        //The input will be a non-negative integer.
        // 16 = 1 + 6 = 7
        // 16

        static public int DigitalRoot(long n)
        {
            var finallResult = n;
            
            long rootStep(long number) 
            {
                var result = 0;
                List<int> digits = new List<int>();
                while (number > 0)
                {
                    digits.Add((int)(number % 10));
                    number = number / 10;
                }
                digits.Reverse();
                foreach (int digit in digits)
                {
                    result += digit;
                }
                return (long)result;
            }

            while (finallResult > 10)
            {
                finallResult = rootStep(finallResult);
            }

            return (int)finallResult;
        }
    }
}
