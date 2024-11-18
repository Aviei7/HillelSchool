int oneValue;
int twoValue;
char operationValue;
int result = 0;

Console.WriteLine("Input first value: ");
oneValue = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input operation(*, /, -, +) value: ");
operationValue = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Input two value: ");
twoValue = Convert.ToInt32(Console.ReadLine());

switch (operationValue)
{
    case '-':
        result = oneValue - twoValue; break;
    case '+':
        result = twoValue + oneValue; break;
    case '*':
        result = oneValue * twoValue; break;
    case '/':
        result = twoValue / oneValue; break;
    default: Console.WriteLine("Operatot '" + operationValue + "' not exists"); break;
};

if (result != 0)
{
    Console.WriteLine("Result: " + result);
};
