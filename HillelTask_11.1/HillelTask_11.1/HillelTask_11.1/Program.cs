using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        int randomIndex, countChance = 6, countTruInput = 0;
        string mainWord, posSymbol = "", existsSymbol = "";
        char inputSymbol = ' ';


        void WordChoise()
        {
            string[] arrWord = ["ручка", "чашка", "чай", "будинок", "мишка"];
            Random randomNum = new Random();
            randomIndex = randomNum.Next(0, 4);
            mainWord = arrWord[randomIndex];
        }

        WordChoise();

        StringBuilder outputText = new StringBuilder($"Вітаємо! Спробуйте вгадати зашифроване слово!\n" +
                                                     $"Кількість літер у слові: {mainWord.Length}\n" +
                                                     $"Кількість можливих невірних спроб: {countChance}\n" +
                                                     $"\n");
        Console.WriteLine(outputText);

        void PrintInfo(int i)
        {
            //1 - Кол-во попыток, 2 - нашли слово, 3 - Угадали слово, 4 - Проигрыш, 5 - ввод буквы
            outputText.Clear();
            if (i == 1)
            {
                outputText.Append($"\nТакої літери немає! Залишилось спроб: {countChance}");
            }
            else if (i == 2)
            {
                outputText.Append($"\nТака літера є у слові! Позиція літери: {posSymbol}");
            }
            else if (i == 3)
            {
                outputText.Append($"\nВітаємо, ви вгадали слово! Зашифроване слово: {mainWord}\n" +
                                      $"Дякуємо за гру.");
            }
            else if (i == 4)
            {
                outputText.Append($"\nКількість спроб закінчилось, ви програли");
            }
            else if (i == 5)
            {
                outputText.Append("Введіть вашу літеру:");
            }
            else if (i == 6)
            {
                outputText.Append($"\nВи вже вводили символ: {inputSymbol}, введіть інший");
            }
            Console.WriteLine(outputText);
        }

        bool CheckDoubleSymbol()
        {
            foreach (char inp in existsSymbol)
            {
                if (inputSymbol == inp)
                {
                    PrintInfo(6);
                    return false;
                }
            }
            return true;
        }

        while (true)
        {
            if (countChance > 0)
            {
                PrintInfo(5);
                inputSymbol = Console.ReadKey().KeyChar;
                if (!CheckDoubleSymbol())
                {
                    continue;
                }

                posSymbol = "";
                for (int i = 0; i < mainWord.Length; i++)
                {
                    if (mainWord[i] == char.ToLower(inputSymbol))
                    {
                        if (posSymbol == "")
                        {
                            posSymbol += (i + 1).ToString();
                        }
                        else
                        {
                            posSymbol += ", ";
                            posSymbol += (i + 1).ToString();
                        }
                        existsSymbol += inputSymbol.ToString();
                        countTruInput++;
                    }
                }

                if (posSymbol != "")
                {
                    if (countTruInput == mainWord.Length)
                    {
                        PrintInfo(3);
                        break;
                    }
                    PrintInfo(2);
                }
                else
                {
                    countChance--;
                    PrintInfo(1);
                }
            }
            else
            {
                PrintInfo(4);
                break;
            }
        }

        


    }
}