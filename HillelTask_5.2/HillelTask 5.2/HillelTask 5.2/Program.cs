
class Program
{
    static void Main()
    {
        string input;
        byte byteNumber;
        int intNumber;
        long longNumber;
        float floatNumber;
        double doubleNumber;


        while (true)
        {
            Console.WriteLine("Write number: ");
            input = Console.ReadLine();

            if (byte.TryParse(input, out byteNumber))
            {
                Console.WriteLine("byte +");
            }
            if (int.TryParse(input, out intNumber))
            {
                Console.WriteLine("Int +");
            }
            if (long.TryParse(input, out longNumber))
            {
                Console.WriteLine("long +");
            }
            if (float.TryParse(input, out floatNumber))
            {
                Console.WriteLine("float +");
            }
            if (double.TryParse(input, out doubleNumber))
            {
                Console.WriteLine("Double +");
            }

        }

    }
}