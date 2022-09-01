using System;

public class Double
{
    public static void Main()
    {
        int x = 20;
        string y = "20";
        try
        {
            
            double ch;
            ch = Convert.ToDouble(x);
            Console.WriteLine("Conversion succeeded.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Cannot convert a Int to a Double.");
        }

        try
        {
            double ch;
            ch = Convert.ToDouble(y);
            Console.WriteLine("Conversion succeeded.");
        }
        catch (InvalidCastException)
        {
            Console.WriteLine("Cannot convert a String to a Double.");
        }
    }
}