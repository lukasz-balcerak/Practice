using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWarsTraining.Class
{
    public static class ClassTaskOne
    {
        public static void DoTaskOne()
        {
            int? max = null;
            int sum = 0;
            int counter = 0;
            int userInput;
            bool endProgram = false;

            do
            {
                Console.WriteLine("Give me a number or put 0 to close...");
                var input = Console.ReadLine();

                if (int.TryParse(input, out userInput))
                {
                    if (counter == 0)
                    {
                        sum += userInput;
                        max = userInput;
                        endProgram = userInput == 0 ? true : false;
                        counter++;
                    }
                    else
                    {
                        sum += userInput;
                        max = userInput > max ? userInput : max;
                        endProgram = userInput == 0 ? true : false;
                        counter++;
                    }

                }
                else
                {
                    Console.WriteLine("Incorect value");
                }

            } while (!endProgram);
            Console.WriteLine($"Maximum value is: {max}");
            Console.WriteLine($"Sumary is: {sum}");
        }

        public static void DoTaskTwo()
        {
            int day;
            int month;
            int year;
            Console.WriteLine("Give me your date of birth:");
            Console.WriteLine("Day:");
            GetDay();
            Console.WriteLine("Month:");
            GetMonth();
            Console.WriteLine("Year:");
            GetYear();

            DateTime dateOfBirth = new DateTime(year, month, day);
            var interval = DateTime.Today - dateOfBirth;
            Console.WriteLine($"Since the date of birth it has been: {interval.TotalDays} days");

            void GetDay()
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out day))
                {
                    if (!(day >= 1 && day <= 31))
                    {
                        Console.WriteLine("Day should be a number in range: 1 - 31");
                        GetDay();
                    }
                }
                else
                {
                    Console.WriteLine("Not a Number. Day should be a number in range 1 - 31");
                    GetDay();
                }
            }

            void GetMonth()
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out month))
                {
                    if (!(month >= 1 && month <= 12))
                    {
                        Console.WriteLine("Month should be a number in range 1 - 12");
                        GetMonth();
                    }
                }
                else
                {
                    Console.WriteLine("Not a Number. Month should be a number in range 1 - 12");
                    GetMonth();
                }
            }

            void GetYear()
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out year))
                {
                    if (!(year >= DateTime.Today.Year - 120 && year <= DateTime.Today.Year))
                    {
                        Console.WriteLine("You're not born yet, or maybe you're already dead");
                        GetYear();
                    }
                }
                else
                {
                    Console.WriteLine("Not a Number. Year should be a number");
                    GetYear();
                }
            }

        }
    }
}
