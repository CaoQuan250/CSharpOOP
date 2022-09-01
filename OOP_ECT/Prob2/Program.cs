using System;
using System.Collections.Generic;
using System.Text;
class Prob2
{
    static void ReadNumber(int start, int end)
    {

        int[] allNumbers = new int[10];
        for (int i = 0; i < 10; i++)
        {
            try
            {
                allNumbers[i] = int.Parse(Console.ReadLine());
                if (allNumbers[i] < start || allNumbers[i] > end)
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid format of input!");
                break;
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("The number is out of the range!");
                break;
            }
            start = allNumbers[i];
        }
    }
    static void Main()
    {
        int start = 1;
        int end = 100;
        ReadNumber(start, end);
    }
}
