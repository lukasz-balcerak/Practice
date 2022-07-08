using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Kata
{
    public class FirstNonRepeatingLetter
    {
        public static string FindLetter (string sentence)
        {
            var result = string.Empty;
            var splitSentence = sentence.ToCharArray().ToList();

            foreach(char c in splitSentence)
            {
            
            }

            result = splitSentence.Find(x => splitSentence.IndexOf(x) == splitSentence.LastIndexOf(x)).ToString();

            if(result == "/0")
            {
                result = string.Empty;
            }

            return result;
        }
    }
}
