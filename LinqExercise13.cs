/*
convert a string array to a string. 
Test Data : 
Input number of strings to store in the array :3 
Input 3 strings for the array : 
Element[0] : cat 
Element[1] : dog 
Element[2] : rat 
Expected Output : 
Here is the string below created with elements of the above array : 
cat, dog, rat
*/

using System;
using System.Linq;
using System.Collections.Generic;

class LinqExercise13 {
    public static void Execute() {

        string[] inputArray;

        Console.Write("\nLINQ : Convert a string array to a string : "); 
        Console.Write("\n------------------------------------------\n");	
        Console.Write("Input number of strings to  store in the array :");

        int numArray = Convert.ToInt32 (Console.ReadLine ());
        inputArray = new string[numArray];

        Console.Write("Input {0} strings for the array:\n", numArray);
        for (int i = 0; i < numArray; i++)
        {
            Console.Write ("Element[{0}]: ", i);
            inputArray[i] = Console.ReadLine();
        }
        string newString = String.Join(", ", inputArray.
            Select(s => s.ToString()).ToArray()
        );

        Console.Write("\nHere is the string below created with elements of the above array  :\n\n");                          
        Console.WriteLine(newString);      

        Console.ReadLine();
    }

}