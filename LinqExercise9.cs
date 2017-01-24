/*
Create a list of numbers and display the numbers greater than 80 as output. 
Test Data : 
The members of the list are : 
55 200 740 76 230 482 95 
Expected Output : 
The numbers greater than 80 are : 
200 
740 
230 
482 
95
*/

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class LinqExercise9 {
    public static void Execute(){
        List<int> tempList = new List<int>();
        tempList.Add(55);  
        tempList.Add(200);  
        tempList.Add(740);  
        tempList.Add(76);  
        tempList.Add(230);  
        tempList.Add(482);  
        tempList.Add(95);
        
        Console.Write ("\nLINQ : Create a list of numbers and display the numbers greater than 80 : ");
        Console.Write("\n-------------------------------------------------------------------------\n");	
        Console.WriteLine("\nThe members of the list are : ");  
        foreach (var num in tempList)
        {
            Console.Write(num + " ");
        }

        List<int> filterList = tempList.FindAll(x => x > 80 ? true : false);

        Console.WriteLine("\n\nThe numbers greater than 80 are : ");
        foreach (var num in filterList)
        {
            Console.Write (num + " ");
        }
        Console.ReadLine();
    }
}