using System;
public class Circle
{

    public static void Main()
    {
        Console.WriteLine("Enter the Radius");
        int a= Convert.ToInt32( Console.ReadLine());
        Area_Circumference(a);
    }

    public static void Area_Circumference(int radius)
    {
        Double pi = 3.141;
        Double area = pi * radius * radius;
        Console.WriteLine("The area of the circel is:{0}",area);
        Double circumference = 2 * pi * radius;
        Console.WriteLine("The circumference of the circel is:{0}",circumference);
    }
}
