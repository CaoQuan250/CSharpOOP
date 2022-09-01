class Prob1 
{
    public static void Main(string[] args)

    {
        
        double x = 0;
        double sqrt;
        try
        {
            Console.Write("Input your number: ");
            x = Convert.ToInt32(Console.ReadLine());
            sqrt = Math.Sqrt(x);
            Console.WriteLine("The square root is: "+sqrt);
        }
        catch (FormatException error)
        {
            sqrt = 0;
            Console.WriteLine("Number must be a positive number");
            Console.WriteLine(error.Message);
        }
        catch (Exception e)
        {
            x = 0;
            sqrt = 0;
            
            Console.WriteLine("You have to input a number");
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("End");
        }

    }
}

