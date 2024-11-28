using System;
using System.Numerics;
using System.Text;
public class ParseValue
{
    public void Parces(string value)
    {
        try
        {
            int.Parse(Console.ReadLine());
        }
        catch 
        {
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        string input;

        while (true)
        {

            Console.WriteLine("Write your ");
            try
            {
                input = Console.ReadLine();
                int.Parse(Console.ReadLine());

            }
            catch (OverflowException ex)
            {
                long.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {  
                Console.WriteLine("Error: " + e.Message);
            
            }
        };

    }
}