// display the number and frequency of number from given array.

using System;
using System.Linq;
using System.Collections.Generic;

class LinqExercise4 {

    public static void Execute () {
        int[] arr1 = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };  
        Console.Write("\nLINQ: Display the number and frequency of number from given array: \n");
        Console.Write("-----------------------------------------------------------------------");
        Console.Write("The numbers in the aray are: \n");
        Console.Write("5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2\n");

        var nQuery =
            from x in arr1
            group x by x into y
            select y;
        
        Console.Write("\nThe number and the frequency are: \n");
        foreach (var arrNo in nQuery)
        {
            Console.WriteLine("Number " + arrNo.Key + " appears " + arrNo.Count() + " times");
        }

        Console.WriteLine ("\n");
    }
}