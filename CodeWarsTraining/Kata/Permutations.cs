using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Kata
{
    public static class Permutations
    {
        public static List<String> elementsList = new List<String>();
        
        public static void GetPermutation(char[] elements)
        {
            int x = elements.Length - 1;
            GetPermutation(elements, 0, x);
        }
        
        private static void GetPermutation(char[] elements, int recursionDeapth, int maxDepth)
        {
            if (recursionDeapth == maxDepth)
            {
                elementsList.Add(new string(elements));
            }
            else
            {
                for (int i = recursionDeapth; i <= maxDepth; i++)
                {
                    Swap(ref elements[recursionDeapth], ref elements[i]);
                    GetPermutation(elements, recursionDeapth + 1, maxDepth);
                    Swap(ref elements[recursionDeapth], ref elements[i]);
                }
            }

        }

        private static void Swap(ref char a, ref char b)
        {
            if (a == b)
            {
                return;
            }

            var tmp = a;
            a = b;
            b = tmp;
        }

    }  
}

