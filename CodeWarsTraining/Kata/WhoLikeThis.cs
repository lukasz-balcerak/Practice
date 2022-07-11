using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Kata
{
    public class WhoLikeThis
    {
        /*
            You probably know the "like" system from Facebook and other pages.
            People can "like" blog posts, pictures or other items.
            We want to create the text that should be displayed next to such an item.
            Implement the function which takes an array containing the names of people that like an item.
            It must return the display text.
        */

        public static string Likes(string[] names)
        {
            int likeCount = names.Length;
            int othersCount = names.Length - 2;

            switch (likeCount)
            {
                case 0: 
                    return "no one likes this";
                case 1:
                    return names[0] + " likes this";
                case 2:
                    return names[0] + " and " + names[1] + " like this";
                case 3:
                    return names[0] + ", " + names[1] + " and " + names[2] + " like this";
                default:
                    return names[0] + ", " + names[1] + " and " + othersCount + " others like this";
            }

        }
    }
}
