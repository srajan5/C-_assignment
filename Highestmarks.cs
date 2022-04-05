using System;
public class Highest_Marks
    {
     public static void Main()
    {
        int a=0;
        int[] marks = new int[5];
        foreach(int i in marks)
        {
            Console.WriteLine("Enter Avg marks:");
            marks[i]= Convert.ToInt32( Console.ReadLine());
            a=Math.Max(a,marks[i]);
        }
        Console.WriteLine("The Highest Marks is {0}", a);
    }

    }

