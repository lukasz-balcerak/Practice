using CodeWarsTraining.Kata;
using System.Text.RegularExpressions;
using System;

var exampleWord = "Hello World";
var exampleArr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

Console.WriteLine(PigLatin.PigIt(exampleWord));
Console.WriteLine(CountCharacters.Count(exampleWord));
Console.WriteLine(MaximumSubarraySum.Sum(exampleArr));


int[] numbers = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

var positive = numbers.Where(x => x > 0).ToList();

var sum = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] > 0)
    {
        var sumDown = 0;
        var sumUp = 0;
        var tempSumDown = 0;
        var tempSumUp = 0;

        for (int j=i; j == 0; j--)
        {
            tempSumDown += numbers[j];
            if(sumDown > tempSumDown)
            {
                sumDown = sumDown;
            } else
            {
                sumDown = tempSumDown;
            }
        }

        for(int k=i; k < numbers.Length; k++)
        {
            tempSumUp += numbers[k];
            if(sumUp > tempSumUp)
            {
                sumUp = sumUp;
            } else
            {
                sumUp = tempSumUp;
            }
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

Console.WriteLine(sum);


