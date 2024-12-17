using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        ////---------------------1
        //Random randomNum = new Random();
        //int[] randArr = new int[10];
        //int firstMaxElement = 0;
        //int twoMaxElement = 0;

        //for (int i = 0; i < randArr.Length; i++)
        //{
        //    randArr[i] = randomNum.Next(-100, 100);
        //}
        ////FirstMaxElement
        //for (int i = 0; i < randArr.Length; i++)
        //{
        //   if (firstMaxElement < randArr[i] )
        //   {
        //        firstMaxElement = randArr[i];
        //   }
        //}
        ////TwomaxElement
        //for (int i = 0; i < randArr.Length; i++)
        //{
        //    if (randArr[i] < firstMaxElement && twoMaxElement < randArr[i])
        //    {
        //        twoMaxElement = randArr[i];
        //    }
        //}
        //Console.WriteLine($"FistMaxElement - {firstMaxElement}, TwoMaxElement - {twoMaxElement}");
        //---------------------2
        //int[,] arrNumbs = new int[3, 3];
        //int[] tmpArr = new int[9];
        //Random randomNum = new Random();
        //int indexElement = 0;
        //int tmpArrNum = 0;

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        arrNumbs[i, j] = randomNum.Next(-100, 100);
        //        Console.WriteLine(arrNumbs[i, j]);
        //    }
        //}

        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        tmpArr[indexElement] = arrNumbs[i, j];
        //        indexElement++;
        //    }
        //}
        ////Сортировка в одномерном массиве
        //for (int i = 0; i < tmpArr.Length; i++)
        //{
        //    for (int j = 0; j < tmpArr.Length; j++)
        //    {
        //        if (j != 8)
        //        {
        //            if (tmpArr[j] > tmpArr[j + 1])
        //            {
        //                tmpArrNum = tmpArr[j];
        //                tmpArr[j] = tmpArr[j + 1];
        //                tmpArr[j + 1] = tmpArrNum;
        //            }
        //        }
        //        else
        //        {
        //            break;
        //        }
        //    }
        //}

        //indexElement = 0;
        ////Обратно заполнение массива после сортировки
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        arrNumbs[i, j] = tmpArr[indexElement];
        //        indexElement++;
        //    }
        //}
        ////Вывод
        //indexElement = 0;
        //for (int i = 0; i < 3; i++)
        //{
        //    for (int j = 0; j < 3; j++)
        //    {
        //        Console.WriteLine($"Element {indexElement + 1} - {arrNumbs[i, j]}");
        //        indexElement++;
        //    }
        //}
        ////---------------------3
        //Random randomNum = new Random();
        //int[] randArr = new int[10];
        //int inputIndex = 0;
        //int indexTracker = 0;
        //for (int i = 0; i < randArr.Length; i++)
        //{
        //    randArr[i] = randomNum.Next(-100, 100);
        //    Console.WriteLine($"Index - {i}. Значення - {randArr[i]}");
        //}
        //try
        //{
        //    Console.WriteLine($"Введіть елемент що потрібно видалити: ");
        //    inputIndex = int.Parse(Console.ReadLine());
        //    if (inputIndex > randArr.Length)
        //    {
        //        Console.WriteLine($"Вказаний індекс виходить за рамки розміру масиву");
        //    }
        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine($"Помилка отримання індексу - {ex.Message}");
        //}

        //if (inputIndex <= randArr.Length-1)
        //{
        //    int[] newRandArr = new int[randArr.Length - 1];
        //    for (int i = 0; i < newRandArr.Length; i++)
        //    {
        //        if (i != inputIndex)
        //        {
        //            newRandArr[i] = randArr[indexTracker];
        //            indexTracker++;
        //        }
        //        else
        //        {
        //            indexTracker++;
        //            newRandArr[i] = randArr[indexTracker];
        //            indexTracker++;
        //        }

        //    }
        //    for (int i = 0; i < newRandArr.Length; i++)
        //    {
        //        Console.WriteLine($"\nIndex - {i}. Значення - {newRandArr[i]}");
        //    }
        //}
        //else
        //{
        //    Console.WriteLine($"Вказаного індексу не існує в масиві");
        //}
        //-----------------4
        int[,] arrNumbs = new int[3, 3];
        Random randomNum = new Random();
        int indexElement = 0;

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                arrNumbs[i, j] = randomNum.Next(-100, 100);
            }
        }

        Console.WriteLine($"(0,0) = {arrNumbs[0, 0]}|(0,1) = {arrNumbs[0, 1]}|(0,2) = {arrNumbs[0, 2]}\n" +
                          $"(1,0) = {arrNumbs[1, 0]}|(1,1) = {arrNumbs[1, 1]}|(1,2) = {arrNumbs[1, 2]}\n" +
                          $"(2,0) = {arrNumbs[2, 0]}|(2,1) = {arrNumbs[2, 1]}|(2,2) = {arrNumbs[2, 2]}\n");

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Element {arrNumbs[i, indexElement]}");
            indexElement++;
        }

    }
}