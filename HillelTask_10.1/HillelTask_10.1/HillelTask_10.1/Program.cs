class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        string input;
        int space;

        Console.WriteLine("Введіть ім'я та призвіще");
        input = Console.ReadLine();
        space = input.IndexOf(' ');

        if (char.ToLower(input[0]) == char.ToLower(input[space + 1]) && space != -1)
        {
            Console.WriteLine("Прізвище починається на ту ж літеру, що і ім’я");
        }
        else if (space == -1)
        {
            Console.WriteLine("Введіть коректне ім'я та призвіще");
        }
        else
        {
            Console.WriteLine("Прізвище не починається на ту ж літеру, що і ім’я");
        }
        
    }
}