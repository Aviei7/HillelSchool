using System;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

class Program
{
    static void Main(string[] args)
    {
        char[,] arrNum = new char[5, 5];
        int x = 0;
        int y = 0;

        string interfaces;
        bool lastStepx = false;


        void DrawOnConsole()
        {
            Console.Clear();
            int drawFlag = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i % 2 == 1)
                    {
                        arrNum[i, j] = '-';
                    }
                    else if (j % 2 == 1)
                    {
                        arrNum[i, j] = '|';
                    }
                    else
                    {
                        drawFlag++;
                        arrNum[i, j] = Convert.ToChar('0' + drawFlag);
                    }


                }
            }

            interfaces = $"{arrNum[0, 0]}{arrNum[0, 1]}{arrNum[0, 2]}{arrNum[0, 3]}{arrNum[0, 4]}\n" +
                                $"{arrNum[1, 0]}{arrNum[1, 1]}{arrNum[1, 2]}{arrNum[1, 3]}{arrNum[1, 4]}\n" +
                                $"{arrNum[2, 0]}{arrNum[2, 1]}{arrNum[2, 2]}{arrNum[2, 3]}{arrNum[2, 4]}\n" +
                                $"{arrNum[3, 0]}{arrNum[3, 1]}{arrNum[3, 2]}{arrNum[3, 3]}{arrNum[3, 4]}\n" +
                                $"{arrNum[4, 0]}{arrNum[4, 1]}{arrNum[4, 2]}{arrNum[4, 3]}{arrNum[4, 4]}";
            Console.WriteLine(interfaces);
        }

        void CheckCombination()
        {
            bool xWin = false;
            bool oWin = false;
            int iflag = 0;
            int countNum = 0;
            //X
            for (int i = 0; i < 5; i += 2)
            {
                xWin = true;
                oWin = true;
                for (int j = 0; j < 5; j += 2)
                {
                    if (arrNum[i, j] != 'x')
                    {
                        xWin = false;
                    }
                    if (arrNum[i, j] != 'o')
                    {
                        oWin = false;
                    }
                }
                if (xWin == true)
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Победа игрока X по горизонтали");
                    Console.SetCursorPosition(x, y);
                    return;
                }
                if (oWin == true)
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Победа игрока O по горизонтали");
                    Console.SetCursorPosition(x, y);
                    return;
                }
            }

            //Y
            for (int i = 0; i < 5; i += 2)
            {
                xWin = true;
                oWin = true;
                for (int j = 0; j < 5; j += 2)
                {
                    if (arrNum[j, i] != 'x')
                    {
                        xWin = false;
                    }
                    if (arrNum[j, i] != 'o')
                    {
                        oWin = false;
                    }
                }
                if (xWin == true)
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Победа игрока X по вертикали");
                    Console.SetCursorPosition(x, y);
                    return;
                }
                if (oWin == true)
                {
                    Console.SetCursorPosition(0, 5);
                    Console.WriteLine("Победа игрока O по вертикали");
                    Console.SetCursorPosition(x, y);
                    return;
                }
            }

            //XY
            xWin = true;
            oWin = true;
            for (int i = 0; i < 5; i += 2)
            {
                if (arrNum[i, i] != 'x')
                {
                    xWin = false;
                }
                if (arrNum[i, i] != 'o')
                {
                    oWin = false;
                }
            }
            if (xWin == true)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победа игрока X по диагонали");
                Console.SetCursorPosition(x, y);
                return;
            }
            if (oWin == true)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победа игрока O по диагонали");
                Console.SetCursorPosition(x, y);
                return;
            }

            xWin = true;
            oWin = true;

            for (int h = 4; h >= 0; h -= 2)
            {
                if (arrNum[h, iflag] != 'x')
                {
                    xWin = false;
                }
                if (arrNum[h, iflag] != 'o')
                {
                    oWin = false;
                }
                iflag += 2;
            }
            if (xWin == true)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победа игрока X по диагонали");
                Console.SetCursorPosition(x, y);
                return;
            }
            if (oWin == true)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Победа игрока O по диагонали");
                Console.SetCursorPosition(x, y);
                return;
            }

            //Заполненость поля
            for (int i = 0; i < 5; i += 2)
            {
                for (int j = 0; j < 5; j += 2)
                {
                    if (char.IsDigit(arrNum[i, j]))
                    {
                        return;
                    }
                    else
                    {
                        countNum++;
                    }
                }

            }
            if (countNum > 0)
            {
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Ничья");
                Console.SetCursorPosition(x, y);
            }
        }
        //start
        DrawOnConsole();
        x = Console.CursorLeft;
        y = Console.CursorTop;

        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(intercept: true);


            switch (keyInfo.Key)
            {
                // Лево
                case ConsoleKey.LeftArrow:
                    x = Math.Max(x - 1, 0);
                    Console.SetCursorPosition(x, y);
                    break;
                // Вправо
                case ConsoleKey.RightArrow:
                    x = Math.Max(x + 1, 0);
                    Console.SetCursorPosition(x, y);
                    break;
                //Вверх
                case ConsoleKey.UpArrow:
                    y = Math.Max(y - 1, 0);
                    Console.SetCursorPosition(x, y);
                    break;
                case ConsoleKey.DownArrow:
                    y = Math.Max(y + 1, 0);
                    Console.SetCursorPosition(x, y);
                    break;
            }

            if (keyInfo.Key == ConsoleKey.X && (x % 2 == 0) && (y % 2 != 1) && lastStepx == false)
            {
                arrNum[y, x] = 'x';
                Console.Write('x');
                CheckCombination();
                lastStepx = true;
            }
            if (keyInfo.Key == ConsoleKey.O && (x % 2 == 0) && (y % 2 != 1) && lastStepx == true)
            {
                arrNum[y, x] = 'o';
                Console.Write('o');
                CheckCombination();
                lastStepx = false;
            }
            if (keyInfo.Key == ConsoleKey.R)
            {
                DrawOnConsole();
                x = 0;
                y = 5;
                Console.SetCursorPosition(x, y);
            }
        }
    }
}