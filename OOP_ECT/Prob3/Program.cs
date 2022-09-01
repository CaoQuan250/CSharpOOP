class Prob3 
{
    static void Main(string[] args)
    {
        string[] weekdays = new string[5];
        

        try
        {
            weekdays[0] = "Sunday";
            weekdays[1] = "Monday";
            weekdays[2] = "Tuesday";
            weekdays[3] = "Wednesday";
            weekdays[4] = "Thursday";

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(weekdays[i].ToString());
            }
            Console.ReadLine();
        }
        catch(Exception ex)
        {
            Console.WriteLine("Error: {0}", ex.Message);
        }
    }

}

