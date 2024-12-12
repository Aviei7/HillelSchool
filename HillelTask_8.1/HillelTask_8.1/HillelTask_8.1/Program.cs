using System;

class Program
{
    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = System.Text.Encoding.UTF8;
    //    ---------------1
    //    Random randomNum = new Random();
    //    int[] randArr = new int[10];

    //    for (int i = 0; i < randArr.Length; i++)
    //    {
    //        randArr[i] = randomNum.Next(-10, 10);
    //        if (i % 2 == 0)
    //        {
    //            Console.WriteLine(randArr[i]);
    //        }
    //    }
    //    ---------------2

    //    Random randomNum = new Random();
    //    int[] randArr = new int[10];
    //    int sumArr = 0;

    //    for (int i = 0; i < randArr.Length; i++)
    //    {
    //        randArr[i] = randomNum.Next(-10, 10);
    //        if (i % 2 == 0)
    //        {
    //            Console.WriteLine(randArr[i]);
    //        }
    //    }

    //    for (int i = 0; i < randArr.Length; i++)
    //    {
    //        sumArr = sumArr + randArr[i];
    //    }
    //    if (sumArr > 0)
    //    {
    //        Console.WriteLine("Сума масиву є не від'ємною");
    //    }
    //    else
    //    {
    //        Console.WriteLine("Сума масиву є від'ємною");
    //    }
    //    ---------------3
    //    int[,] nubmerArray = new int[9, 9];

    //    for (int i = 0; i < 9; i++)
    //    {
    //        for (int j = 0; j < 9; j++)
    //        {
    //            nubmerArray[i, j] = (j + 1) * (i + 1);
    //            Console.WriteLine(nubmerArray[i, j]);
    //        }
    //    }
    //    ---------------4
    //    int[,] nubmerArray = new int[5, 5];
    //    Random randomNum = new Random();
    //    int min = 0, max = 0;
    //    string coordinMax = "", coordinMin = "";

    //    //--Заполнение
    //    for (int i = 0; i < 5; i++)
    //    {
    //        for (int j = 0; j < 5; j++)
    //        {
    //            nubmerArray[i, j] = randomNum.Next(-100, 100);
    //        }
    //    }

    //    //--Поиск
    //    for (int i = 0; i < 5; i++)
    //    {
    //        for (int j = 0; j < 5; j++)
    //        {
    //            if (min < nubmerArray[i, j])
    //            {
    //                min = nubmerArray[i, j];
    //                coordinMin = $"{i}, {j}";
    //            }

    //            if (max > nubmerArray[i, j])
    //            {
    //                max = nubmerArray[i, j];
    //                coordinMax = $"{i}, {j}";
    //            }
    //        }
    //    }
    //    Console.WriteLine($"Найменше значення = {min}, Координати = {coordinMin}. Найбільше значення = {max}, Координати = {coordinMax}. ");
    //    
    //}
    //----------------5
    enum WeekDays
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Введіть кількість днів: ");
        int day = int.Parse(Console.ReadLine());
        day = day % 7;
        string dayname = Convert.ToString(Enum.GetValues(typeof(WeekDays)).GetValue(day));

        Console.WriteLine($"День неділі - {dayname}");
    }
}