using System;

public class ParamPara
{
    public static void ParamSum(params int[] numbers)
    {
        int Total = 0;
        foreach (int i in numbers)
        {
            Total = Total + i;
        }
        Console.WriteLine("Sum of all passed parameters is: {0}", Total);
    }
    public static void Main()
    {
        int[] numbers = { 5, 10, 15 };

        ParamSum(numbers);
    }
}
