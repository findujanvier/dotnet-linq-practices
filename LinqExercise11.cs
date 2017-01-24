/*
display the top nth records. 
Test Data : 
The members of the list are : 
5 
7 
13 
24 
6 
9 
8 
7 
How many records you want to display ? : 3 
Expected Output : 
The top 3 records from the list are : 
24 
13 
9
*/
using System;  
using System.Collections.Generic;  
using System.Linq;   

class LinqExercise11 {
    public static void Execute (){
        List<int> templist = new List<int>();
        templist.Add(5);
        templist.Add(7);
        templist.Add(13);
        templist.Add(24);
        templist.Add(6);
        templist.Add(9);
        templist.Add(8);
        templist.Add(7);

        Console.Write("\nLINQ : Display top nth records from the list: "); 
        Console.Write("\n----------------------------------------------\n");

        Console.WriteLine("\nThe members of the list are : ");
        foreach (var member in templist)
        {
            Console.Write (member + " ");
        }

        Console.Write("\nHow many records you want to display ? : "); 
        int n = Convert.ToInt32 (Console.ReadLine());

        templist.Sort();
        templist.Reverse();

        Console.Write("The top {0} records from the list are :\n", n);
        foreach (var topN in templist.Take(n))
        {
            Console.Write(topN+ " ");
        }

        Console.ReadLine();
    }
}