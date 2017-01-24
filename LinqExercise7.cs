/* display numbers, multiplication of number with frequency and the frequency of number of giving array.
the number in the array are: 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 

Expected Output : 
Number Number*Frequency Frequency 
------------------------------------------------ 
5 15 3 
1 1 1 
9 9 1 
2 4 2 
*/

using System;
using System.Linq;
using System.Collections.Generic;

class LinqExercise7 {
    public static void Execute (){
        int[] nums = new int[] { 5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 };

        Console.Write ("\nLINQ: Display numbers, number*frequency and frequency: ");
        Console.Write ("\n-----------------------------------------------------\n");

        Console.Write ("The numbers in the array are: \n");
        Console.Write ("5, 1, 9, 2, 3, 7, 4, 5, 6, 8, 7, 6, 3, 4, 5, 2 \n");

        var query = 
            from x in nums
            group x by x into y
            select y;

        Console.Write ("Number" + "\t" + "Number*Frequency" + "\t" + "Frequency" + "\n");
        Console.Write ("-----------------------------------------------------\n");

        foreach (var arrEle in query)
        {
            Console.WriteLine (arrEle.Key + "\t" + arrEle.Sum() + "\t\t\t" + arrEle.Count());
        }
        Console.WriteLine();
    }

}