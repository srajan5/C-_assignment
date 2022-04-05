using System;
public class calculator
{
    public static void Main()
    {
        Console.WriteLine("Enter First Number");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Second Number");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The difference is {0}", a - b);

        calculator.Add(a, b);
        calculator.Subtraction(a, b);
        calculator.Multiplication(a, b);
        calculator.Division(a, b);

    }

    public static void Add(int a, int b)
    {
        int c = a + b;
        Console.WriteLine("The Sum is {0}", c);
    }

    public static void Subtraction(int a, int b)
    {
        int c = a - b;
        Console.WriteLine("The Difference is {0}", c);
    }

    public static void Multiplication(int a, int b)
    {
        int c = a * b;
        Console.WriteLine("The product is {0}", c);
    }

    public static void Division(float a, float b)
    {
        float c = a / b;
        Console.WriteLine("The Division is {0}", c);
    }
}
