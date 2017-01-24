/* 
Find the string which starts and ends with a specific character. 
Test Data : 
The cities are : 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' 
Input starting character for the string : A 
Input ending character for the string : M
Expected Output : 
The city starting with A and ending with M is : AMSTERDAM
*/
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

class LinqExercise8 {
    public static void Execute () {
        string firstChar, lastChar;
        char inputChar;

        string[] cities = {
            "ROME","LONDON","NAIROBI","CALIFORNIA","ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI", "PARIS"  
        };

        Console.Write ("\nLINQ: Find the string which starts and ends with a specific character: ");
        Console.Write ("\n---------------------------------------------------------------------\n");
        Console.Write ("\nThe cities are: 'ROME','LONDON','NAIROBI','CALIFORNIA','ZURICH','NEW DELHI','AMSTERDAM','ABU DHABI','PARIS' \n");

        Console.Write("\nInput starting character for the string : "); 
        inputChar = (char)Console.Read(); 
        firstChar = inputChar.ToString();
        
        Console.Write("\nInput ending character for the string : "); 
        inputChar = (char)Console.Read(); 
        lastChar = inputChar.ToString();
        
        var query = 
            from x in cities
            where x.StartsWith(firstChar)
            where x.EndsWith("M")
            select x;

        Console.Write ("\n\n");

        foreach (var city in query)
        {
            Console.Write ("The city starting with {0} and ending with {1} is : {2} \n", firstChar, lastChar, city);
        }
        // Console.ReadLine();
    }
}