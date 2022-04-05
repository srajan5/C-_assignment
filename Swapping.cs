using System;
public class Swap
{

    public static void Main()
    {
        Console.WriteLine("Enter the First Number");
        int a=Convert.ToInt32(  Console.ReadLine());
        Console.WriteLine("Enter the Second Number");
        int b = Convert.ToInt32 (Console.ReadLine());
        Swap.SwappingNumbers(a, b);

    }

    public static void SwappingNumbers(int a,int b)
    {
        int c = a;
        a = b;
        b = c;
        Console.WriteLine("The swapped value of a is {0} b is {1}", a, b);
    }
}
