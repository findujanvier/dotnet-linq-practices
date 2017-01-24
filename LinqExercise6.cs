// display the name of the week.
// Sunday Monday Tuesday Wednesday Thursday Friday Saturday

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class LinqExercise6 {

    public static void Execute (){
        string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        Console.Write ("\nLINQ: Display the name of the days of a week: ");
        Console.Write ("\n--------------------------------------------\n");

        var days = 
            from WeekDay in dayWeek
            select WeekDay;

        foreach (var WeekDay in dayWeek)
        {
            Console.WriteLine (WeekDay);
        }
        Console.WriteLine();

    }
}
