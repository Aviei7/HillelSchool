//-------1.Обчислення середнього заробітку
//int countEmployee;
//int salary;
//decimal sumSalaryEmployee = 0;
//decimal resultSumSalary;

//Console.WriteLine("How many employees do you have in your company: ");
//countEmployee = int.Parse(Console.ReadLine());

//for (int i = 1; i < countEmployee + 1; i++)
//{
//    Console.WriteLine("Write salary to employee " + i + ": ");
//    salary = int.Parse(Console.ReadLine());
//    sumSalaryEmployee += salary;
//}
//resultSumSalary = sumSalaryEmployee / countEmployee;
//Console.WriteLine("Average salary: " + resultSumSalary);

//------2.Побудова графіку зірочками
//string stars = "";
//int input;

//Console.WriteLine("Write number line: ");
//input = int.Parse(Console.ReadLine());

//for (int i = 0; i < input; i++)
//{
//    stars += "*";
//    Console.WriteLine(stars);
//}

//3.Генерація простих чисел(не готово)

//int inputuser;

//Console.WriteLine("write the maximum number to generate prime a number: ");
//inputuser = int.Parse(Console.ReadLine());

//for (int i = 1; i < inputuser; i++)
//{
//    if (Math.Pow(2, i - 1) % i == 1)
//    {
//        Console.WriteLine($"Prime number = {i}");
//    }
//}

//------4.Перевірка паролю
//string passwordInput;
//bool isGoodSymbol = false;
//bool isGoodNumber = false;
//int lenghPassword = 0;

//    Console.WriteLine("Write password: ");
//    passwordInput = Console.ReadLine();

//    foreach (char password in passwordInput)
//    {
//        lenghPassword++;
//        //Console.WriteLine($"now: {password}");
//        if (char.IsSymbol(password) || char.IsPunctuation(password))
//        {
//            isGoodSymbol = true;
//        }

//        if (char.IsDigit(password))
//        {
//            isGoodNumber = true;
//        }
//    }
//    if ((!isGoodSymbol) || (!isGoodNumber) || lenghPassword < 8)
//    {
//        Console.WriteLine($"Password not true: Special symbol - {isGoodSymbol}, Number exists - {isGoodNumber}, Lengh - {lenghPassword}");
//    }
//    else
//    {
//        Console.WriteLine("Password good");
//    }
//-------5.Генерація фібоначчівської послідовності
//int inputNumberCount;
//int oneValue = 0;
//int twoValue = 1;

//Console.WriteLine($"Write count number: ");
//inputNumberCount = int.Parse(Console.ReadLine());

//for (int i = 0; i < inputNumberCount / 2; i++)
//{

//    oneValue = oneValue + twoValue;
//    Console.WriteLine($"{oneValue}");
//    twoValue = oneValue + twoValue;
//    Console.WriteLine($"{twoValue}");
//}

//-------6.Калькулятор оплати праці за годину
//float dayHour;
//float salaryInHour;
//decimal result;

//Console.WriteLine($"Write work hour a day: ");
//dayHour = int.Parse(Console.ReadLine());

//Console.WriteLine($"Write work salary a hour: ");
//salaryInHour = int.Parse(Console.ReadLine());

//result = Convert.ToDecimal(salaryInHour * dayHour);
//Console.WriteLine($"Pay per day: {result}");

//--------7.Генерація таблиці множення для конкретного числа
//int input;

//Console.WriteLine("Write number: ");
//input = int.Parse(Console.ReadLine());
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine($"{input}*{i}");
//}
//--------8.Перевірка на простоту
//int inputUser;
//bool isPrime = true;
//Console.WriteLine("Write the maximum number to generate prime a number: ");
//inputUser = int.Parse(Console.ReadLine());

//for (int i = 2; i <= inputUser-1; i++)
//{
//    if (inputUser % i == 0)
//    {
//        isPrime = false;
//        break;
//    }

//}

//if (isPrime)
//{
//    Console.WriteLine($"Number {inputUser} is prime");
//}
//else
//{
//    Console.WriteLine($"Number {inputUser} is not prime");
//}
