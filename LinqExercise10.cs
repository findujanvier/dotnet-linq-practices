/*
Accept the members of a list through the keyboard and display the members more than a specific value. 
Test Data : 
Input the number of members on the List : 5 
Member 0 : 10 
Member 1 : 48 
Member 2 : 52 
Member 3 : 94 
Member 4 : 63 
Input the value above you want to display the members of the List : 59
Expected Output : 
The numbers greater than 59 are : 
94 
63
*/

using System;  
using System.Collections.Generic;  
using System.Linq;  
using System.Text;  

class LinqExercise10 {
    public static void Execute () {

        int memList, countInput, compareInput;

        List<int> tempList = new List<int> ();

        Console.Write("\nLINQ : Accept the members of a list and display the members more than a specific value : "); 
        Console.Write("\n----------------------------------------------------------------------------------------\n");

        Console.Write("Input the number of members on the List : ");  
        countInput = Convert.ToInt32 (Console.ReadLine());

        for (int i = 0; i < countInput; i++)
        {
            Console.Write ("Member {0}: ", i);
            memList = Convert.ToInt32(Console.ReadLine());
            tempList.Add (memList);
        }

        Console.Write ("\nInput the value above you want to display the members of the list: ");
        compareInput = Convert.ToInt32 (Console.ReadLine());

        var filterList = tempList.FindAll (x => x > compareInput ? true : false);

        Console.WriteLine ("\nThe numbers greater than {0} are: ", compareInput);

        foreach (var num in filterList)
        {
            Console.Write (num + ", ");
        }
        Console.ReadLine();
    }
}