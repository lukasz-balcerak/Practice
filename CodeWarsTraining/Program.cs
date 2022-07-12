using System.Text.RegularExpressions;
using System;
using CodeWarsTraining.Class;
using CodeWarsTraining.Kata;

var exampleWord = "stress";
var exampleArr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
var signature = new double[] { 13, 17, 10 };
var stepsInFibo = 1;
var namesArry = new string[] { "Lucas", "Eva", "Marco", "Elizabeth" };
var simpleNumber = 942;
var simpleWord = "aabb";
char[] simpleWordArr = simpleWord.ToCharArray();


//Console.WriteLine(PigLatin.PigIt(exampleWord));
//Console.WriteLine(CountCharacters.Count(exampleWord));
//Console.WriteLine(MaximumSubarraySum.Sum(exampleArr));
//var triboResult = Tribonnaci.Tribo(signature, stepsInFibo);
//for( int i = 0; i < stepsInFibo; i++)
// Console.WriteLine(triboResult[i]);
//Console.WriteLine(FirstNonRepeatingLetter.FindLetter(exampleWord));
//ClassTaskOne.DoTaskOne();
//ClassTaskOne.DoTaskTwo();
//Console.WriteLine(WhoLikeThis.Likes(namesArry));
//Console.WriteLine(SumOfDigits.DigitalRoot(simpleNumber));
Permutations.GetPermutation(simpleWordArr);
var list = Permutations.elementsList;
var listWithOutDuplicate = list.Distinct().ToList();
var count = 0;
foreach(var item in listWithOutDuplicate)
{
    Console.WriteLine(listWithOutDuplicate[count]);
    count++;
}
