// display the characters and frequency of character from giving string
using System;
using System.Linq;
using System.Collections.Generic;

class LinqExercise5{
    public static void Execute (){
        string str;
        Console.Write("\nLINQ: display the characters and frequency of character from giving string: ");
        Console.Write("\n--------------------------------------------------------------------------\n");

        Console.Write("Input the string: ");
        str = Console.ReadLine();

        Console.Write("\n");

        var freQ =
            from x in str
            group x by x into y
            select y;

        Console.Write("The frequency of the characters are: \n");
        foreach (var arrEle in freQ)
        {
            Console.WriteLine("Character " + arrEle.Key + ": " + arrEle.Count() + " times");
        }
    }
}