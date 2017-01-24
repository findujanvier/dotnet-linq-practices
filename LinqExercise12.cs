/*
 find the uppercase words in a string. 
Test Data : 
Input the string : this IS a STRING 
Expected Output : 
The UPPER CASE words are : 
IS 
STRING
*/

using System;
using System.Linq;
using System.Collections.Generic;

class LinqExercise12 {
    public static void Execute (){
        Console.Write("\nLINQ : Find the uppercase words in a string : "); 
        Console.Write("\n----------------------------------------------\n");

        Console.Write("Input the string: ");
        var inputStr = Console.ReadLine();

        var upperCaseWords = WordFilt(inputStr);

        Console.Write("\nThe UPPER CASE words are :\n");
        foreach (string word in upperCaseWords)
        {
            Console.WriteLine(word);
        }
        Console.ReadLine();
    }

    static IEnumerable<string> WordFilt (string inputStr) {
        var upWord =  inputStr.Split(' ').Where( w => w == w.ToUpper());

        return upWord;
    }
}