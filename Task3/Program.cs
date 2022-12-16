using static System.Console;

WriteLine("Enter a number: ");

int day = int.Parse(ReadLine()!);

if(day <= 7 && day >= 1)
{
    if(day == 3)
    {
        WriteLine("Wednesday");
    }

    if(day == 5)
    {
        WriteLine("Friday");
    }

    if(day == 1)
    {
        WriteLine("Monday");
    }

    if(day == 2)
    {
        WriteLine("Tuesday");
    }

    if(day == 4)
    {
        WriteLine("Thursday");
    }
}
else
{
    WriteLine("Such day does not exist");
}
