// find the +ve numbers from a list of numbers using two where conditions in LINQ Query.

using System;
using System.Linq;

class LinqExercise2 {
    public static void Execute () {
        int[] n1 = {1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14};

        Console.Write ("\nLINQ: using multiple WHERE clause to find the +ve numbers within the list: ");
        Console.Write ("\n---------------------------------------------------------------------------");

        var nQuery = 
            from VrNum in n1
            where VrNum > 0
            where VrNum < 12
            select VrNum;
        
        Console.Write ("The numbers within the range of 1 to 11 are : \n");
        foreach (var VrNum in nQuery)
        {
            Console.Write("{0} ", VrNum);
        }
        Console.Write("\n\n");
    }
}