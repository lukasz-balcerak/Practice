using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Kata
{
    public class MaximumSubarraySum
    {
        public static int Sum(int[] arr)
        {
            var sum = 0;

            for(int i = 0; i <arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    var sumDown = 0;
                    var sumUp = 0;
                    var tempSumDown = 0;
                    var tempSumUp = 0;

                    for (int j = i; j == 0; j--)
                    {
                        tempSumDown += arr[j];
                        sumDown = sumDown > tempSumDown ? sumDown : tempSumDown;
                    }

                    for (int k = i; k < arr.Length; k++)
                    {
                        tempSumUp += arr[k];
                        sumUp = sumUp > tempSumUp ? sumUp : tempSumUp;
                    }

                    if(sumUp > sum)
                    {
                        sum = sumUp;
                    } else if (sumDown > sum)
                    {
                        sum = sumDown;
                    } else
                    {
                        continue;
                    }

                } else
                {
                    continue;
                }
            }

            return sum;
        }
    }
}
