using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Kata
{
    public class Tribonnaci
    {
        /*
        Fibbonaci with sum of three arguments
        n - elements 
        signature - first three elements
        if n = 0 return empty arr.
        */
        public static double[] Tribo(double[] signature, int n)
        {
            double[] result = new double[n];
            if (n == 0)
            {

            }
            else if (n == 1)
            {
                result[0] = signature[0];
            }
            else if (n == 2)
            {
                result[1] = signature[1];
            }
            else
            {
                result[0] = signature[0];
                result[1] = signature[1];
                result[2] = signature[2];

                for (int i = 3; i < n; i++)
                {
                    result[i] = result[i - 3] + result[i - 2] + result[i - 1];
                }
            }

            return result;

            /*
            Best practice:

                double[] res = new double[n];
                Array.Copy(s, res, Math.Min(3, n));
    
                for(int i = 3; i < n; i++)
                    res[i] = res[i - 3] + res[i - 2] + res[i - 1];
    
                return n == 0 ? new double[]{0} : res;
            */
        }
    }
}
