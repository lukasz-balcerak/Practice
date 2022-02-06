using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Kata
{
    public class Tribonnaci
    {
        public static double[] Tribo(double[] signature, int n)
        {
            double[] result = new double[n];
            
            result[0] = signature[0];
            result[1] = signature[1];
            result[2] = signature[2];

            for(int i = 3; i < n; i++)
            {
                result[i] = result[i-3] + result[i-2] + result[i-1];
            }

            return result;
        }
    }
}
