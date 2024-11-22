using System;
using System.Numerics;
using System.Text;

public class Calculator
{
    public int oneValue;
    public int twoValue;
    public char operationValue;
    public int result;

    public int Operators(char operationValue)
    {
        try
        {
            switch (operationValue)
            {
                case '-':
                    result = oneValue - twoValue; break;
                case '+':
                    result = oneValue + twoValue; break;
                case '*':
                    result = oneValue * twoValue; break;
                case '/':
                    result = oneValue / twoValue; break;
                default: Console.WriteLine("Operatot '" + operationValue + "' not exists"); break;
            };
        }
        catch 
        {
            Console.WriteLine("This operation is not corrct: '" + oneValue + operationValue + twoValue +"'");
        }

        return result;
    }
}

class Program
{
    static void Main()
    {
        string step;
        while (true)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine("Input first value: ");
            calculator.oneValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input operation(*, /, -, +) value: ");
            calculator.operationValue = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Input two value: ");
            calculator.twoValue = Convert.ToInt32(Console.ReadLine());

            calculator.result = calculator.Operators(calculator.operationValue);


            if (calculator.result != 0)
            {
                Console.WriteLine("Result: " + calculator.result);
            };

            Console.WriteLine("Do you want restart calculator? (yes/no)");
            step = Console.ReadLine();
            if (step.ToLower() == "no")
            {
                break;
            }

        }
    }
}