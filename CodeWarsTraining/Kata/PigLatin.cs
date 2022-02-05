using System;
using System.Text.RegularExpressions;

namespace CodeWarsTraining.Kata
{
    public class PigLatin
    {
        /*
        Move the first letter of each word to the end of it
        Then add "ay" to the end of the word.
        Leave punctuation marks untouched
        */

        public static string PigIt(string str)
        {
            string[] words = str.Split(' ');
            string newString = "";
            Regex regex = new Regex("^[^<>{}\"/|;:.,~!?@#$%^=&*\\]\\\\()\\[¿§«»ω⊙¤°℃℉€¥£¢¡®©0-9_+]*$");
            
            foreach (string word in words)
            {
                if (!regex.IsMatch(word))
                {
                    newString += word + " ";
                }
                else
                {
                    var letter = word[0];
                    newString += word.Substring(1) + letter + "ay" + " ";
                }

            }
            return newString;
            /*
            Using Linq --> best practice
            return string.Join(" ", str.Split(' ').Select(w => w.Any(char.IsPunctuation) ? w : w.Substring(1) + w[0] + "ay"));
            */
        }
    }
}
