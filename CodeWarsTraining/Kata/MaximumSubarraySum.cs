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
            /*
            The maximum sum subarray problem consists in finding the maximum sum of a contiguous subsequence in an array or list of integers:
            Easy case is when the list is made up of only positive numbers and the maximum sum is the sum of the whole array. 
            If the list is made up of only negative numbers, return 0 instead.
            Empty list is considered to have zero greatest sum. Note that the empty list or array is also a valid sublist/subarray.
             */

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

            /*
             * Best practice
             * 
             int max = 0, res = 0, sum = 0;
             foreach(var item in arr)
             {
                sum += item;
                max = sum > max ? max : sum;
                res = res > sum - max ? res : sum - max;
             }
                return res; 
             */
        }
    }
}
