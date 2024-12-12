class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string input;
        int spaceIndex;

        Console.WriteLine("Введіть ім'я та призвіще");
        input = Console.ReadLine();

        foreach (char c in input)
        {
            spaceIndex = input.IndexOf(' ');
            if (spaceIndex != -1)
            {
                input = input.Remove(spaceIndex, 1);
            }
            else
            {
                break;
            }
        }
        Console.WriteLine(input);
    }
}