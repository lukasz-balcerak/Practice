using CodeWarsTraining.Kata;
using System.Text.RegularExpressions;
using System;

var exampleWord = "Hello World";
var exampleArr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
var signature = new double[] { 13, 17, 10 };
var stepsInFibo = 1;


Console.WriteLine(PigLatin.PigIt(exampleWord));
Console.WriteLine(CountCharacters.Count(exampleWord));
Console.WriteLine(MaximumSubarraySum.Sum(exampleArr));
var triboResult = Tribonnaci.Tribo(signature, stepsInFibo);
for( int i = 0; i < stepsInFibo; i++)
{
    Console.WriteLine(triboResult[i]);
}
