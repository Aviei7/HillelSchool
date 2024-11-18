int inputUser;
bool Cycle = true;

while (Cycle)
{
    Console.WriteLine("Write number day week: ");
    inputUser = Convert.ToInt16(Console.ReadLine());

    string dayName = inputUser switch
    {
        1 => "Monday",
        2 => "Tuesday",
        3 => "Wednesday",
        4 => "Thursday  ",
        5 => "Friday ",
        6 => "Saturday ",
        7 => "Sunday ",
        _ => "Unknown day"
};

    Console.WriteLine(dayName);

}