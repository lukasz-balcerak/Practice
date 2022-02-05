using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Kata
{
    public class CountCharacters
    {
        /* The main idea is to count all the occuring characters in a string
        If you have string aba then result should be {'a': 2, 'b':1}
        What if string is empty ? Then result should be empty object literal {}
        */

        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();
            foreach (char c in str)
            {
                if (result.ContainsKey(c))
                {
                    result[c] = result[c] + 1;
                    Console.WriteLine(result[c]);
                }
                else
                {
                    result.Add(c, 1);
                    Console.WriteLine(result[c]);
                }
            }

            return result;

            /*
            Best practice with Linq
            return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            */
        }
    }
}
