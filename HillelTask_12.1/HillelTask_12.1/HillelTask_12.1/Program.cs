using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int inputNumberCount;
        Console.WriteLine($"Write count number: ");
        inputNumberCount = int.Parse(Console.ReadLine());
        int oneValue = 0;
        int twoValue = 1;
        int count = 0;
        StringBuilder strB = new StringBuilder();
        Recursion();

        void Recursion()
        {
            if (count < inputNumberCount/2)
            {
                oneValue += twoValue;

                strB.Append($"{oneValue} \n");

                if (count < inputNumberCount / 2 - 1)
                {
                    twoValue += oneValue;
                    strB.Append($"{twoValue} \n");
                }
                count++;
                Recursion();
            }
            else
            {
                return;
            }
            
        }

        Console.WriteLine($"Порядок фібоначчі \n{strB}");
    }
}