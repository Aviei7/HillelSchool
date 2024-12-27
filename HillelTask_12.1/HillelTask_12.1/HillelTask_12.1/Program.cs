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
            oneValue += twoValue;
            twoValue += oneValue;
            if (oneValue < inputNumberCount)
            {
                strB.Append($"{oneValue} \n");
            }
            else
            {
                return;
            }

            if (twoValue < inputNumberCount)
            {
                strB.Append($"{twoValue} \n");
            }
            else
            {
                return;
            }
            count++;
            Recursion();
        }

        Console.WriteLine($"Порядок фібоначчі \n{strB}");
    }
}