using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        StringBuilder stringB = new StringBuilder();
        DateTime dayNow = DateTime.Now.Date;

        bool IsWork = true;
        string Date = dayNow.ToString("yyyy-MM-dd");
        int iventCount = 1;
        int iventInputCount = 0;

        while (IsWork)
        {
            //Title
            Console.WriteLine($"Введіть заголовок звіту: ");
            stringB.AppendLine($"Заголовок:{Console.ReadLine()}");
            //Date
            stringB.AppendLine($"Дата створення:{Date.ToString()}");
            //Invent
            //InventInpCount
            Console.WriteLine($"Введіть заплановану кількість подій у звіті: ");
            iventInputCount = int.Parse(Console.ReadLine());
            stringB.AppendLine($"Список подій:");
            while (IsWork)
            {
                if (iventCount <= iventInputCount)
                {
                    //IventList
                    Console.WriteLine($"Введіть подію");
                    stringB.AppendLine($"Подія номер {iventCount}:{Console.ReadLine()} ");
                    iventCount++;
                }
                else
                {
                    IsWork = false;
                    Console.WriteLine(stringB);
                }
            }
        }

    }
}