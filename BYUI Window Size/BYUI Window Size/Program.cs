using System;

class GlazerCalc
{
    static void Main()
    {
        double width, height, woodLength, glassArea;
        string widthString, heightString;

        Console.WriteLine("Input width");
        widthString = Console.ReadLine();

        Console.WriteLine("Input Height");
        heightString = Console.ReadLine();

        CalculateTHIS.cal(double.Parse(widthString), double.Parse(heightString));

      
    }
}

public class CalculateTHIS
{
    internal static void cal(double width, double height)
    {
        double woodLength, glassArea;

        woodLength = 2 * (width + height) * 3.25;
        glassArea = 2 * (width * height);

        Console.WriteLine("The length of the wood is " +
        woodLength + " feet");
        Console.WriteLine("The area of the glass is " +
        glassArea + " square metres");

    }
}